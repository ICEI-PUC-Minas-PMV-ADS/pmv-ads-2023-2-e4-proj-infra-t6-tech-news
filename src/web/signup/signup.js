function registerUser(event) {
            event.preventDefault(); // Impede o envio do formulário

            // Obtém os valores dos campos de e-mail e senha
            var email = document.getElementById("email").value;
            var password = document.getElementById("password").value;

          
                // Constrói o objeto de dados para enviar ao endpoint
                var data = {
                    email: email,
                    password: password
                };

                // Envia os dados para o endpoint usando o método POST
                fetch("http://localhost:3000/users", {
                    method: "POST",
                    headers: {
                        "Content-Type": "application/json"
                    },
                    body: JSON.stringify(data)
                })
                .then(function(response) {
                    if (response.ok) {
                        // Registro bem-sucedido
                        alert("Usuário registrado com sucesso!");
                        document.getElementById("registrationForm").reset();
                    } else {
                        // Registro falhou
                        alert("Erro ao registrar usuário. Tente novamente.");
                    }
                })
                .catch(function(error) {
                    // Erro de conexão ou outra falha
                    alert("Erro ao conectar ao servidor. Verifique a URL do endpoint.");
                });
             
          }
