# Arquitetura da Solução

A arquitetura de solução é um elemento fundamental no campo da tecnologia da informação e sistemas de informação. Ela desempenha um papel crucial na concepção, desenvolvimento e implementação de sistemas complexos e eficazes para atender às necessidades de negócios e tecnológicas de uma organização. 

A seguir está a arquitetura distribuída da solução, com os serviços e componentes que fazem parte da solução.

![Arquitetura da Solução Distribuida](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e4-proj-infra-t6-ingresso-facil/assets/82043220/0f5c2c67-5db1-4fd7-b94f-2422bf89383b)

## Diagrama de Classes

O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Classes”.

> - [Diagramas de Classes - Documentação da IBM](https://www.ibm.com/docs/pt-br/rational-soft-arch/9.6.1?topic=diagrams-class)
> - [O que é um diagrama de classe UML? | Lucidchart](https://www.lucidchart.com/pages/pt/o-que-e-diagrama-de-classe-uml)

## Modelo ER

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.]

As referências abaixo irão auxiliá-lo na geração do artefato “Modelo ER”.

> - [Como fazer um diagrama entidade relacionamento | Lucidchart](https://www.lucidchart.com/pages/pt/como-fazer-um-diagrama-entidade-relacionamento)

## Esquema Relacional

O Esquema Relacional corresponde à representação dos dados em tabelas juntamente com as restrições de integridade e chave primária.
 
As referências abaixo irão auxiliá-lo na geração do artefato “Esquema Relacional”.

> - [Criando um modelo relacional - Documentação da IBM](https://www.ibm.com/docs/pt-br/cognos-analytics/10.2.2?topic=designer-creating-relational-model)

## Modelo Físico

Entregar um arquivo banco.sql contendo os scripts de criação das tabelas do banco de dados. Este arquivo deverá ser incluído dentro da pasta src\bd.

## Tecnologias Utilizadas

O desenvolvimento de software moderno depende de uma variedade de tecnologias para criar produtos eficientes e inovadores. Nesta seção, destacamos algumas das principais tecnologias utilizadas no processo de desenvolvimento do sistema proposto.

A imagem abaixo representa a comunicação entre algumas das tecnologias utilizadas no desenvolvimento do sistema:

![Novo mural (1)](https://github.com/brunosellas/pmv-ads-2023-2-e4-proj-infra-t6-ingresso-facil/assets/102563767/a7b7cd7c-ad4b-4bff-b934-a6e3b32c227f)

Todas as tecnologias utilizadas abaixo são relacionadas apenas ao processo de desenvolvimento dos MICROSERVICES *CATALOG* e *AUTHENTICATION*, estão listadas abaixo, separadas por tópicos e contém um breve resumo dos motivos de sua escolha.

### Linguagens

As linguagens de programação são a base do desenvolvimento de software. Dependendo dos requisitos e objetivos do projeto, diferentes linguagens podem ser utilizadas.

<table>
 <tr>
   <td colspan='2' align='center'><strong>Linguagens</strong></td>
 </tr>
 <tr>
   <td width='200' align='center'><strong>Linguagem</strong></td>
   <td width='800'><strong>Motivo da escolha</strong></td>
 </tr>
  <tr>
    <td align='center'><a href='https://www.typescriptlang.org/'>TypeScript</a></td>
   <td> O TypeScript (TS) foi pré-definido para as etapas 3 e 4 de desenvolvimento do projeto do eixo 4 da <a href='https://www.pucminas.br/PucVirtual/Paginas/default.aspx'>PucMinas Virtual</a>, sendo a linguagem escolhida para o desenvolvimento Front-End Web e Mobile em conjuntos dos frameworks ReactJs e React-native.</td>
 </tr>
  <tr>
   <td align='center'><a href='https://learn.microsoft.com/pt-br/dotnet/csharp/tour-of-csharp/'>C#</a></td>
   <td>O C# em conjunto dos frameworks .NeET.0 e ASP.NET6.0 foram escolhidos para o desenvolvimento da Api, sendo o C# uma linguagem orientada à objetos e fortemente tipada, ela disponibiliza recursos que facilitam a criação de webapis.</td>
 </tr>
</table>

### Bibliotecas

As bibliotecas são conjuntos de código predefinido e reutilizável que fornecem funcionalidades específicas para facilitar o desenvolvimento de software. Elas são criadas para resolver problemas comuns e oferecer uma abordagem mais eficiente e rápida para a construção de aplicativos

<table>
 <tr>
   <td colspan='2' align='center'><strong>Bibliotecas</strong></td>
 </tr>
 <tr>
   <td width='200' align='center'><strong>Biblioteca</strong></td>
   <td width='800'><strong>Motivo da escolha</strong></td>
 </tr>
  <tr>
    <td align='center'><a href='https://nativebase.io/'>Native Base</a></td>
   <td>A biblioteca de componentes Native Base foi escolhida por proporcionar uma grande variedade de components e estilizações que auxiliam no processo de criação das páginas da aplicação.</td>
 </tr>
  <tr>
   <td align='center'><a href='https://www.npmjs.com/package/axios'>Axios</a></td>
   <td>A biblioteca Axios foi escolhida para o acesso a webapi, por ser muito objetiva e fácil de ser utilizada.</td>
 </tr>
  <tr>
   <td align='center'><a href='https://learn.microsoft.com/pt-br/ef/core/'>Entity Framework</a></td>
   <td>O Entity framework é um mapeador relacional de objeto (ORM) que permite o acesso a dados como objetos, é muito usado por apis desenvolvidas com .NET e fácil de ser utilizada.</td>
 </tr>
  <tr>
   <td align='center'><a href='https://github.com/react-native-async-storage/async-storage'>AsyncStorage</a></td>
   <td>O AsyncStorage é a biblioteca mais usual para armazenamento de dados localmente em dispositivos móveis.</td>
 </tr>
</table>

### Ambiente de desenvolvimento

Um ambiente de desenvolvimento padronizado e bem definido, permite que todos os desenvolvedores trabalhem em conjunto, evitando problemas de incompatibilidade entre ambientes de desenvolvimento.

<table>
 <tr>
   <td colspan='2' align='center'><strong>Ambiente de desenvolvimento</strong></td>
 </tr>
 <tr>
   <td width='200' align='center'><strong>Tecnologia</strong></td>
   <td width='800'><strong>Motivo da escolha</strong></td>
 </tr>
  <tr>
   <td align='center'><a href='https://code.visualstudio.com/'>Visual Studio Code</a></td>
   <td>O VS code é um editor de código aberto leve e com uma vasta variedade de recursos, que possibilita o desenvolvimento com react-js e react-native em qualquer sistema operacional.</td>
 </tr>
  <tr>
   <td align='center'><a href='https://visualstudio.microsoft.com/pt-br/'>Visual Studio 2022</a></td>
   <td>O IDE mais abrangente para desenvolvedores .NET no Windows. Totalmente empacotado com uma bela matriz de ferramentas e recursos para elevar e aprimorar cada estágio de desenvolvimento de software.</td>
 </tr>
  <tr>
   <td align='center'><a href='https://developer.android.com/studio'>Android Studio</a></td>
   <td>O Android Studio é uma IDE para desenvolvimento mobile, que conta com recursos de emulação de dispositivos móveis, permitindo um preview da aplicação enquanto em ambiente de desenvolvimento.</td>
 </tr>
</table>


### Serviços web

Os serviços web desempenham um papel fundamental no mundo digital de hoje, permitindo a comunicação e a troca de informações entre diferentes sistemas e aplicativos em todo o mundo. Esses serviços são essenciais para facilitar a integração de plataformas, o compartilhamento de dados e o desenvolvimento de soluções modernas e interconectadas.

<table>
 <tr>
   <td colspan='2' align='center'><strong>Serviços</strong></td>
 </tr>
 <tr>
   <td width='200' align='center'><strong>Serviço</strong></td>
   <td width='800'><strong>Motivo da escolha</strong></td>
 </tr>
  <tr>
   <td align='center'><a href='https://render.com/'>Render</a></td>
   <td>O Render é um web host gratuito que possibilita a hospedagem da api e do banco de dados da aplicação.</td>
 </tr>
</table>

### Comunicação

Uma comunicação rápida e eficaz desempenha um papel vital nos processos de desenvolvimento de uma aplicação, então é importante que os meios de comunicação sejam efetivos e acessíveis a todos.

<table>
 <tr>
   <td colspan='2' align='center'><strong>Comunicação</strong></td>
 </tr>
 <tr>
   <td width='200' align='center'><strong>Tecnologia</strong></td>
   <td width='800'><strong>Motivo da escolha</strong></td>
 </tr>
  <tr>
   <td align='center'><a href='https://www.microsoft.com/pt-br/microsoft-teams/group-chat-software'>Microsoft Teams</a></td>
   <td>O Microsoft Teams facilita a comunicação durante todo o ciclo do projeto, contendo recursos de compartilhamento de tela que são essenciais para uma reunião mais assertiva.</td>
 </tr>
  <tr>
   <td align='center'><a href='https://www.whatsapp.com/'>Whatsapp</a></td>
   <td>O Whatsapp possibilita uma comunicação mais rápida entre os stakeholders, tornando a comunicação no projeto mais fluida e direta.</td>
 </tr>
</table>

### UI Design

Uma boa ferramenta de design de interface do usuário (UI) pode desempenhar um papel crucial no desenvolvimento de uma experiência de usuário eficaz e atraente.

<table>
 <tr>
   <td colspan='2' align='center'><strong>UI Design</strong></td>
 </tr>
 <tr>
   <td width='200' align='center'><strong>Tecnologia</strong></td>
   <td width='800'><strong>Motivo da escolha</strong></td>
 </tr>
  <tr>
   <td align='center'><a href='https://www.figma.com/'>Figma</href></td>
   <td>O Figma é um serviço web que permite a criação de design da aplicação de maneira simples e gratuita.</td>
 </tr>
</table>


## Hospedagem

Explique como a hospedagem e o lançamento da plataforma foi feita.

> **Links Úteis**:
>
> - [Website com GitHub Pages](https://pages.github.com/)
> - [Programação colaborativa com Repl.it](https://repl.it/)
> - [Getting Started with Heroku](https://devcenter.heroku.com/start)
> - [Publicando Seu Site No Heroku](http://pythonclub.com.br/publicando-seu-hello-world-no-heroku.html)

## Qualidade de Software

Conceituar qualidade de fato é uma tarefa complexa, mas ela pode ser vista como um método gerencial que através de procedimentos disseminados por toda a organização, busca garantir um produto final que satisfaça às expectativas dos stakeholders.

No contexto de desenvolvimento de software, qualidade pode ser entendida como um conjunto de características a serem satisfeitas, de modo que o produto de software atenda às necessidades de seus usuários. Entretanto, tal nível de satisfação nem sempre é alcançado de forma espontânea, devendo ser continuamente construído. Assim, a qualidade do produto depende fortemente do seu respectivo processo de desenvolvimento.

A norma internacional ISO/IEC 25010, que é uma atualização da ISO/IEC 9126, define oito características e 30 subcaracterísticas de qualidade para produtos de software.
Com base nessas características e nas respectivas sub-características, identifique as sub-características que sua equipe utilizará como base para nortear o desenvolvimento do projeto de software considerando-se alguns aspectos simples de qualidade. Justifique as subcaracterísticas escolhidas pelo time e elenque as métricas que permitirão a equipe avaliar os objetos de interesse.

> **Links Úteis**:
>
> - [ISO/IEC 25010:2011 - Systems and software engineering — Systems and software Quality Requirements and Evaluation (SQuaRE) — System and software quality models](https://www.iso.org/standard/35733.html/)
> - [Análise sobre a ISO 9126 – NBR 13596](https://www.tiespecialistas.com.br/analise-sobre-iso-9126-nbr-13596/)
> - [Qualidade de Software - Engenharia de Software 29](https://www.devmedia.com.br/qualidade-de-software-engenharia-de-software-29/18209/)
