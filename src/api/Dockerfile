FROM ubuntu:20.04

ENV BUNDLER_VERSION=2.4.10 \
  GEM_HOME=/vendor/bundle
ENV BUNDLE_PATH="$GEM_HOME" \
  BUNDLE_BIN="$GEM_HOME/bin" \
  BUNDLE_SILENCE_ROOT_WARNING=1 \
  BUNDLE_APP_CONFIG="$GEM_HOME"
ENV PATH=$BUNDLE_BIN:$PATH \
  BUNDLE_JOBS=4 \
  BUNDLE_RETRY=3 \
  DOCKER=true \
  TERM=xterm \
  DEBIAN_FRONTEND=noninteractive

# Install apt-utils
RUN apt-get update
RUN apt-get install -y --no-install-recommends apt-utils

# setup locales
ENV LANG en_US.UTF-8
ENV LANGUAGE en_US.UTF-8
ENV LC_ALL en_US.UTF-8
RUN apt-get clean && apt-get update && apt-get install -y locales
RUN locale-gen en_US.UTF-8
RUN dpkg-reconfigure --frontend=noninteractive locales
RUN locale

# setup basic packages
RUN apt-get update && apt-get install -y apt-transport-https ca-certificates \
  wget curl vim build-essential lsb-release graphviz \
  xz-utils

# Install Ruby
RUN apt-get update -qq && apt-get install -y build-essential software-properties-common \
  fswatch git pkg-config libxml2-dev libxslt-dev sqlite3 libsqlite3-dev libreadline-dev libyaml-dev \
  zlib1g-dev libffi-dev libssl-dev unzip zip libpthread-stubs0-dev

RUN wget https://ftp.ruby-lang.org/pub/ruby/3.0/ruby-3.0.6.tar.gz && \
  tar -xvzf ruby-3.0.6.tar.gz && cd ruby-3.0.6/ && \
  ./configure --prefix=/usr/local && \
  make && \
  make install

# Install postgresql-client-14
RUN wget --quiet -O - https://www.postgresql.org/media/keys/ACCC4CF8.asc | apt-key add -
RUN echo "deb http://apt.postgresql.org/pub/repos/apt/ `lsb_release -cs`-pgdg main" | tee  /etc/apt/sources.list.d/pgdg.list
RUN apt-get update -qq && apt-get install -y \
  postgresql-client-14 postgresql-14 postgresql-contrib-14 libpq-dev

# Install Node and Yarn
RUN curl -sL https://deb.nodesource.com/setup_14.x | bash -\
  && apt-get update -qq && apt-get install -qq --no-install-recommends \
  nodejs \
  && apt-get upgrade -qq \
  && apt-get clean \
  && rm -rf /var/lib/apt/lists/*\
  && npm install -g yarn@1

RUN mkdir /news_api
ADD . /news_api/
WORKDIR /news_api/

RUN npm --version
RUN node -v
RUN yarn --version

RUN yarn install

# Install gems
RUN gem install bundler --version "$BUNDLER_VERSION" \
  && mkdir -p "$GEM_HOME" "$BUNDLE_BIN" \
  && chmod 777 "$GEM_HOME" "$BUNDLE_BIN"
RUN bundle config set path "$GEM_HOME"
RUN bundle config set --local force_ruby_platform true
RUN bundle config build.stackprof --with-ldflags=-pthread
RUN bundle lock --add-platform ruby
RUN bundle install --jobs=$BUNDLE_JOBS --retry=$BUNDLE_RETRY

ENV RAILS_ENV=test \
  CHROME_BIN="/usr/bin/google-chrome"

# Expose port 3000 from the container
EXPOSE 3000

# Run puma server by default
CMD ["bundle", "exec", "puma", "-C", "config/puma.rb"]
