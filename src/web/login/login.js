function loginUser(event) {
  event.preventDefault(); // Impede o envio do formulário

  // Obtém os valores dos campos de e-mail e senha
  var email = document.getElementById("email").value;
  var password = document.getElementById("password").value;

 
    // Constrói o objeto de dados para enviar ao endpoint
    var data = {
      email: email,
      password: password,
    };

    // Envia os dados para o endpoint usando o método POST
    fetch("http://localhost:3000/users", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(data),
    })
      .then(function (response) {
        if (response.ok) {
          // Login bem-sucedido, redireciona para a página home.html
          window.location.href = "../home/home.html";
        } else {
          // Login falhou
          alert("Login inválido. Verifique seu e-mail e senha.");
        }
      })
      .catch(function (error) {
        // Erro de conexão ou outra falha
        alert("Erro ao conectar ao servidor. Verifique a URL do endpoint.");
      });
   
}