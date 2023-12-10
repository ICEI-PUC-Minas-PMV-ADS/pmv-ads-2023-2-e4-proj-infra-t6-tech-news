
function registerUser(event) {
    event.preventDefault(); // Previne o envio padrão do formulário

    // Obtém os valores dos campos de título e link
    var titulo = document.getElementById("titulo").value;
    var link = document.getElementById("link").value;

    // Constrói o objeto de dados para enviar ao endpoint
    var data = {
        titulo: titulo,
        link: link
    };

    // Envia os dados para o endpoint usando o método POST
    fetch("http://localhost:3000/news", {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(data)
    })
        .then(function (response) {
            if (response.ok) {
                // Cadastro bem-sucedido
                alert("Notícia cadastrada com sucesso!");
            } else {
                // Cadastro falhou
                alert("Falha ao cadastrar notícia. Verifique os dados.");
            }
        })
        .catch(function (error) {
            // Erro de conexão ou outra falha
            alert("Erro ao conectar ao servidor. Verifique a URL do endpoint.");
        });
}
