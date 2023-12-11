import http from '@lib/httpService';

const URL_REGEX = /(https:\/\/www\.|http:\/\/www\.|https:\/\/|http:\/\/)?[a-zA-Z]{2,}(\.[a-zA-Z]{2,})(\.[a-zA-Z]{2,})?\/[a-zA-Z0-9]{2,}|((https:\/\/www\.|http:\/\/www\.|https:\/\/|http:\/\/)?[a-zA-Z]{2,}(\.[a-zA-Z]{2,})(\.[a-zA-Z]{2,})?)|(https:\/\/www\.|http:\/\/www\.|https:\/\/|http:\/\/)?[a-zA-Z0-9]{2,}\.[a-zA-Z0-9]{2,}\.[a-zA-Z0-9]{2,}(\.[a-zA-Z0-9]{2,})?/g;
const apiEndpoint = '/news';

export function listNews() {
  return http.get(apiEndpoint);
}

export function createNews(title: string, link: string) {
  if (!URL_REGEX.test(link)) {
    return Promise.reject('Invalid URL');
  }

  return http.post(apiEndpoint, { title, link });
}

export function updateNews(id: number, title: string, link: string) {
  if (!URL_REGEX.test(link)) {
    return Promise.reject('Invalid URL');
  }

  return http.put(`${apiEndpoint}/${id}`, { title, link });
}

export function deleteNews(id: number) {
  return http.delete(`${apiEndpoint}/${id}`);
}
