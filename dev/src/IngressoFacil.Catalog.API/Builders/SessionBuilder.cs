using FluentResults;
using IngressoFacil.Catalog.API.Errors;
using IngressoFacil.Catalog.API.Models;

namespace IngressoFacil.Catalog.API.Builders {
    public class SessionBuilder {

        private Session _session;
        private Result<Session> _result;
        public SessionBuilder CreateNew() {
            _session = new Session();
            _result = new Result<Session>();

            return this;
        }
        public SessionBuilder WithStartTime(TimeSpan startTime) {

            if (_result is null || _session is null) {
                throw new InvalidOperationException("Call 'CreateNew' method for create a new session.");
            }

            if (startTime < new TimeSpan(8,0,0) || startTime > new TimeSpan(22,0,0)) {
                _result.WithError(new SessionStartTimeIsNotValidError());
                return this;
            }

            _session.StartTime = startTime;

            return this;
        }
        public SessionBuilder WithDate(DateOnly date) {

            if (_result is null || _session is null) {
                throw new InvalidOperationException("Call 'CreateNew' method for create a new session.");
            }

            if (date < DateOnly.FromDateTime(DateTime.Today)) {
                _result.WithError(new SessionDateBeforeTodayError());
                return this;
            }

            _session.Date = date;

            return this;
        }
        public Result<Session> Build() {

            if (_result is null || _session is null) {
                throw new InvalidOperationException("Call 'CreateNew' method for create a new session.");
            }

            if (_result.IsSuccess) {
                _result.WithValue(_session);
            }

            return _result;
        }
    }
}
