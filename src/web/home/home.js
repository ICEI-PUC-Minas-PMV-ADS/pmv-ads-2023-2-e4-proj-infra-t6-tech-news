// Função para buscar e exibir as notícias na tabela
function fetchAndRenderNews() {
  // Faz a requisição GET ao endpoint /noticias
  fetch('http://localhost:3000/news')
    .then(response => response.json()) // Transforma a resposta em JSON
    .then(data => {
      const tableBody = document.getElementById('table-body');

      // Limpa o conteúdo existente da tabela
      tableBody.innerHTML = '';

      // Para cada notícia, cria uma nova linha na tabela
      data.forEach(news => {
        const row = document.createElement('tr');

        // Cria células para o título e o link
        const titleCell = document.createElement('td');
        titleCell.textContent = news.titulo;
        const linkCell = document.createElement('td');
        linkCell.textContent = news.link;

        // Adiciona as células à linha
        row.appendChild(titleCell);
        row.appendChild(linkCell);

        // Adiciona a linha à tabela
        tableBody.appendChild(row);
      });
    })
    .catch(error => {
      console.error('Ocorreu um erro:', error);
    });
}

// Chama a função para buscar e renderizar as notícias ao carregar a página
window.addEventListener('load', fetchAndRenderNews);
