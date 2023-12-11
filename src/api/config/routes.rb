Rails.application.routes.draw do
  devise_for :users, controllers: {
    registrations: 'users/registrations',
    sessions: 'users/sessions'
  }

  devise_scope :user do
    get '/users/current', to: 'users/sessions#current'
    delete '/users/sign_out', to: 'users/sessions#destroy'
  end

  resources :news do
    member do
      post 'like'
    end
  end
end
