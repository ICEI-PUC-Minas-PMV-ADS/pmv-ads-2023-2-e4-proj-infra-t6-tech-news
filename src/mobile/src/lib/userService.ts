import http from './httpService';

const apiEndpoint = '/users';

export const EMAIL_REGEX = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/

export function createUser(email: string, password: string, password_confirmation: string) {
  if (email === '' || password === '' || password_confirmation === '') {
    return Promise.reject('Email and password are required');
  }

  if (!EMAIL_REGEX.test(email)) {
    return Promise.reject('Email is invalid');
  }

  if (password !== password_confirmation) {
    return Promise.reject('Password and password confirmation do not match');
  }

  const user = { user: { email, password, password_confirmation } };

  return http.post(apiEndpoint, user);
}
