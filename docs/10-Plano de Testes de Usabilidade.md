# Plano de Testes de Usabilidade



O teste de usabilidade permite avaliar a qualidade da interface com o usuário da aplicação interativa. O Plano de Testes de Software é gerado a partir da especificação do sistema e consiste em casos de testes que deverão ser executados quando a implementação estiver parcial ou totalmente pronta.

Para realizarmos os testes de usabilidade no nosso aplicativo, consideraremos a opinião de 5 usuários e faremos uma média de suas avaliações. A avaliação será realizada através da escala Likert, de 1 a 5, sendo:

| **Nota** | **Facilidade de Uso** |
|:---:	|:---:	|
| 5 | O usuário não apresentou erros nem demora. |
| 4 | O usuário não apresentou erros, mas demorou para a finalização do teste. |
| 3 | O usuário encontrou um erro não-crítico nos fluxos ou precisou de ajuda simples. |
| 2 | O usuário encontrou erros não-críticos nos fluxos ou precisou de ajuda. |
| 1 | O usuário encontrou erros críticos ou obteve valores incorretos em um caso de teste. |

Ou seja, quanto maior a nota, maior será a facilidade de uso para o usuário. Os casos de teste que serão usados para avaliação estão abaixo:

| **Caso de teste 1** | **Cadastro de Notícia** |
|:---:	|:---:	|
| Objetivo do teste | Verificar se o usuário consegue identificar e preencher os campos necessários para cadastrar uma notícia. |
| Ações esperadas | 1) Acessar a aplicação. <br> 2) Clicar em "Cadastrar Notícia". <br> 3) Preencher as informações solicitadas e clicar em "Cadastrar". |
| Critérios de êxito | A notícia é cadastrada com sucesso. |

| **Caso de teste 2** | **Login de Usuário** |
|:---:	|:---:	|
| Objetivo do teste | Verificar se o usuário consegue fazer o login na aplicação. |
| Ações esperadas | 1) Acessar a aplicação. <br> 2) Clicar em "Fazer login". <br> 3) Inserir as informações solicitadas e clicar em "Entrar". |
| Critérios de êxito | O usuário consegue logar na sua conta. |


| **Caso de teste 3** | **Visualização de Notícias** |
|:---:	|:---:	|
| Objetivo do teste | Verificar se as notícias são exibidas corretamente na interface. |
| Ações esperadas | 1) Acessar a aplicação. <br> 2) Navegar até a seção de "Notícias". <br> 3) Verificar se as notícias são exibidas com os detalhes corretos. |
| Critérios de êxito | As notícias são exibidas corretamente na interface. |

| **Caso de teste 4** | **Gerenciamento de Notícias** |
|:---:	|:---:	|
| Objetivo do teste | Verificar se o usuário consegue adicionar, editar e excluir notícias. |
| Ações esperadas | 1) Acessar a aplicação. <br> 2) Clicar na seção de "Gerenciar Notícias". <br> 3) Adicionar uma nova notícia. <br> 4) Editar os detalhes de uma notícia existente. <br> 5) Excluir uma notícia. |
| Critérios de êxito | A notícia é adicionada com sucesso. |
| Critérios de êxito | Os detalhes da notícia são editados com sucesso. |
| Critérios de êxito | A notícia é excluída com sucesso. |

