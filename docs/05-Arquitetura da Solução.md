# Arquitetura da Solução

A arquitetura de solução desempenha um papel essencial no âmbito da tecnologia da informação e sistemas correlatos. Ela exerce uma influência crucial na concepção, desenvolvimento e implementação de sistemas robustos e eficientes, os quais são projetados para atender às exigências tanto do negócio quanto das necessidades tecnológicas de uma organização.

Abaixo está apresentada a arquitetura distribuída da solução, destacando os serviços e componentes integrantes do sistema.

![fluxo2](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e4-proj-infra-t6-tech-news/assets/105467049/75cafe9e-578c-4745-a3a2-c79c19f71cd5)


## Diagrama de Classes

O diagrama de classe é uma representação visual que descreve a estrutura e as interações entre as classes em um sistema orientado a objetos. Ele oferece uma visão abstrata dos objetos presentes no sistema, incluindo seus atributos e métodos.

A figura a seguir apresenta o diagrama de classes para o sistema proposto, destacando a organização das classes e suas relações.
![database](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e4-proj-infra-t6-tech-news/assets/105467049/8ce2e034-5659-435a-9abf-a0e5776c6e21)


As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Classes”.

> - [Diagramas de Classes - Documentação da IBM](https://www.ibm.com/docs/pt-br/rational-soft-arch/9.6.1?topic=diagrams-class)
> - [O que é um diagrama de classe UML? | Lucidchart](https://www.lucidchart.com/pages/pt/o-que-e-diagrama-de-classe-uml)



## Tecnologias Utilizadas

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
   <td>Para a construção da interface de usuário, escolhemos utilizar TypeScript em conjunto com React e React Native. O TypeScript, uma linguagem baseada em JavaScript, traz consigo a vantagem da tipagem estática, fornecendo maior segurança e facilitando a manutenção do código. Integrado com o React para a web e o React Native para desenvolvimento mobile, essa combinação oferece uma base sólida para a criação de interfaces responsivas e eficientes, garantindo uma experiência consistente tanto em aplicativos web quanto em dispositivos móveis.</td>
 </tr>
  <tr>
   <td align='center'><a href='https://rubyonrails.org/'>RUBY</a></td>
   <td>Para o desenvolvimento da API, optamos por utilizar Ruby on Rails. Rails é um framework conhecido por sua eficiência e praticidade no desenvolvimento web. A linguagem Ruby, combinada com o framework Rails, oferece uma abordagem ágil e poderosa para a criação de APIs. A estrutura do Rails simplifica muitos aspectos do desenvolvimento, permitindo a rápida implementação de funcionalidades e a gestão eficiente dos recursos do sistema.</td>
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

A qualidade de software é um aspecto essencial para o sucesso de qualquer projeto de desenvolvimento e entrega de software. Ela abrange uma variedade de atributos, como funcionalidade, confiabilidade, usabilidade, eficiência e segurança, que são cruciais para garantir a satisfação dos usuários e a competitividade no mercado.  

Para o sistema propostos foram escolhidas algumas características de qualidade com base na norma [ISO/IEC 25010:2011](https://www.iso.org/standard/35733.html) (anteriormente conhecida como [ISO/IEC 9126](https://www.iso.org/standard/22749.html)), que tratam de Funcionalidade, Eficiência, Usabilidade e Manutenibilidade. Para o controle da qualidade de software, foram estabelecidas métricas com base na norma [ISO/IEC 25021:2011](https://www.iso.org/standard/55477.html), que faz parte da família de normas [ISO/IEC 25000 (SQuaRE)](https://www.iso.org/standard/64764.html) e trata de Referências para Medição de Qualidade, fornecendo diretrizes e conceitos relacionados à medição da qualidade do software. Abaixo está uma distribuição do peso de cada característica de qualidade na avaliação do sistema:

![grafico-qualidade](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e3-proj-mov-t1-shape-up/assets/82043220/cc28e53a-fceb-42a7-8a8a-dffc2acca256)

Essa distribuição será usada para calcular o percentual de qualidade do sistema, durante o processo de análise das métricas será gerado um relatório geral de qualidade que será usado para concluir o estado atual da aplicação diante seus usuários, sendo os seguintes estados:

<table>
  <tr>
    <td width='200'><strong>Percentual</strong></td>
    <td width='800'><strong>Estado da aplicação</strong></td>
  <tr>
    <td>80% ou Superior</td>
    <td>O Sistema atende todos os requisitos de qualidade, entregando muito valor ao usuário.</td>
  </tr>
  <tr>
    <td>entre 60% e 79%</td>
    <td>O Sistema atende boa parte dos requisitos de qualidade, entregando valor ao usuário.</td>
  </tr>
  <tr>
    <td>entre 30% e 59%</td>
    <td>O Sistema atende apenas alguns dos requisitos de qualidade, entregando pouco valor ao usuário.</td>
  </tr>
  <tr>
    <td>abaixo de 30%</td>
    <td>O Sistema não atende os requisitos de qualidade, não entregando valor ao usuário.</td>
  </tr>
</table>


As características de qualidade, juntamente com suas subcaracterísticas escolhidas para esse sistema seram abordadas a seguir:

## Adequação Funcional
A adequação funcional é uma característica de qualidade essencial para um software. Refere-se à capacidade do software de fornecer as funcionalidades e os recursos necessários para atender às necessidades e expectativas dos usuários. 

### Integridade funcional
A integridade funcional é uma característica de qualidade fundamental em software, que se refere à precisão e consistência dos dados manipulados e dos resultados produzidos pelo sistema.Em termos simples, um software com alta integridade funcional é capaz de realizar suas funções corretamente, sem corromper ou modificar os dados de forma inesperada.

Foi escolhida como uma qualidade de software por estar diretamente relacionada ao valor que agrega ao usuário, sendo fundamental para um sistema bem estruturado, a integridade é um dos pontos mais importantes em uma aplicação.

#### Métrica

<table>
  <tr>
    <td align='center' colspan='3'><strong>Integridade funcional - 12pts</strong></td>
  </tr>
  <tr>
    <td colspan='3'>Com que frequência há perda de informação durante o processamento dos dados?</td>
  </tr>
  <tr>
    <td width='100' align='center'><strong>Opção</strong></td>
    <td width='800' align='center'><strong>Descrição</strong></td>
    <td width='100' align='center'><strong>Pontuação</strong></td>
  </tr>
  <tr>
    <td align='center'>a)</td>
    <td>Muito frequente</td>
    <td>0 pts</td>
  </tr>
  <tr>
    <td align='center'>b)</td>
    <td>Frequente</td>
    <td>4 pts</td>
  </tr>
  <tr>
    <td align='center'>c)</td>
    <td>Pouco frequente</td>
    <td>8 pts</td>
  </tr>
  <tr>
    <td align='center'>d)</td>
    <td>Não há perda de informação</td>
    <td>12 pts</td>
  </tr>
</table>


### Correção funcional

A correção funcional é uma característica de qualidade vital em software, que se concentra na capacidade do sistema de funcionar corretamente, livre de erros e defeitos. Essa característica busca garantir que o software execute suas funcionalidades conforme especificado, atendendo aos requisitos estabelecidos.

Essa característica foi escolhida por estar ligada ao controle de falhas, sendo um ponto essêncial para garantir que o sistema funcione como esperado.

#### Métrica

<table>
  <tr>
    <td align='center' colspan='3'><strong>Correção funcional - 6pts</strong></td>
  </tr>
  <tr>
    <td colspan='3'>Com que frequência o sistema apresenta erros inesperados?</td>
  </tr>
  <tr>
    <td width='100' align='center'><strong>Opção</strong></td>
    <td width='800' align='center'><strong>Descrição</strong></td>
    <td width='100' align='center'><strong>Pontuação</strong></td>
  </tr>
  <tr>
    <td align='center'>a)</td>
    <td>Muito frequente</td>
    <td>0 pts</td>
  </tr>
  <tr>
    <td align='center'>b)</td>
    <td>frequente</td>
    <td>2 pts</td>
  </tr>
  <tr>
    <td align='center'>c)</td>
    <td>Pouco frequente</td>
    <td>4 pts</td>
  </tr>
  <tr>
    <td align='center'>d)</td>
    <td>O Sistema não apresenta erros inesperados</td>
    <td>6 pts</td>
  </tr>
</table>

### Pertinência funcional

A pertinência funcional é uma característica de qualidade que se concentra na relevância e utilidade das funcionalidades oferecidas pelo software. Refere-se à capacidade do sistema de fornecer as funcionalidades que são realmente necessárias e significativas para os usuários e para os objetivos do negócio. 

Essa característica foi escolhida por estar ligado diretamente ao usuário, e em como as funcionalidades do sistema atendem as necessidades dele e geram valor.

#### Métrica

<table>
  <tr>
    <td align='center' colspan='3'><strong>Pertinência funcional - 12pts</strong></td>
  </tr>
  <tr>
    <td colspan='3'>O Software atende a todas as necessidades do seu posto de trabalho?</td>
  </tr>
  <tr>
    <td width='100' align='center'><strong>Opção</strong></td>
    <td width='800' align='center'><strong>Descrição</strong></td>
    <td width='100' align='center'><strong>Pontuação</strong></td>
  </tr>
  <tr>
    <td align='center'>a)</td>
    <td>não atende</td>
    <td>0 pts</td>
  </tr>
  <tr>
    <td align='center'>b)</td>
    <td>atende parcialmente</td>
    <td>4 pts</td>
  </tr>
  <tr>
    <td align='center'>c)</td>
    <td>atende plenamente</td>
    <td>8 pts</td>
  </tr>
  <tr>
    <td align='center'>d)</td>
    <td>possui mais funções do que necessito</td>
    <td>12 pts</td>
  </tr>
</table>

## Eficiência de Desempenho

A eficiência de desempenho é uma característica de qualidade que se concentra na capacidade do software de executar suas funcionalidades de maneira eficiente, otimizando o uso de recursos, como processamento, memória e largura de banda. Essa característica busca garantir que o software seja capaz de entregar um desempenho adequado dentro dos limites estabelecidos, levando em consideração fatores como tempo de resposta, velocidade de processamento e utilização eficiente dos recursos disponíveis.

### Comportamento temporal

O comportamento temporal é uma característica de qualidade que se refere à capacidade do software de cumprir requisitos relacionados ao tempo, como prazos, tempo de resposta e frequência de atualização. Essa característica busca garantir que o software seja capaz de responder e processar informações dentro de limites de tempo aceitáveis.

Foi escolhido por estar ligado ao tempo de resposta da aplicação, sendo um fator importante para aplicações que fazem comunicação com banco de dados e serviços web.

#### Métrica

<table>
  <tr>
    <td align='center' colspan='3'><strong>Comportamento temporal - 12pts</strong></td>
  </tr>
  <tr>
    <td colspan='3'>Qual o tempo médio de resposta de ações na aplicação?</td>
  </tr>
  <tr>
    <td width='100' align='center'><strong>Opção</strong></td>
    <td width='800' align='center'><strong>Descrição</strong></td>
    <td width='100' align='center'><strong>Pontuação</strong></td>
  </tr>
  <tr>
    <td align='center'>a)</td>
    <td>10s</td>
    <td>0 pts</td>
  </tr>
  <tr>
    <td align='center'>b)</td>
    <td>6s</td>
    <td>4 pts</td>
  </tr>
  <tr>
    <td align='center'>c)</td>
    <td>4s</td>
    <td>8 pts</td>
  </tr>
  <tr>
    <td align='center'>d)</td>
    <td>2s</td>
    <td>12 pts</td>
  </tr>
</table>

### Capacidade

A capacidade é uma característica de qualidade que se refere à capacidade do software de lidar com volumes de dados, usuários ou transações em conformidade com os requisitos estabelecidos. Essa característica busca garantir que o software seja capaz de escalar e suportar a carga de trabalho esperada, sem comprometer o desempenho ou a disponibilidade do sistema.

Essa característica foi escolhida por estar relacionada a robustez do sistema em lidar com volumes grandes de dados.

#### Métrica

<table>
  <tr>
    <td align='center' colspan='3'><strong>Capacidade - 6pts</strong></td>
  </tr>
  <tr>
    <td colspan='3'>Qual é a quantidade máxima de dados que o software pode armazenar?</td>
  </tr>
  <tr>
    <td width='100' align='center'><strong>Opção</strong></td>
    <td width='800' align='center'><strong>Descrição</strong></td>
    <td width='100' align='center'><strong>Pontuação</strong></td>
  </tr>
  <tr>
    <td align='center'>a)</td>
    <td>1GB</td>
    <td>0 pts</td>
  </tr>
  <tr>
    <td align='center'>b)</td>
    <td>10GB</td>
    <td>2 pts</td>
  </tr>
  <tr>
    <td align='center'>c)</td>
    <td>100GB</td>
    <td>4 pts</td>
  </tr>
  <tr>
    <td align='center'>d)</td>
    <td>1TB</td>
    <td>6 pts</td>
  </tr>
</table>

## Usabilidade

A usabilidade é uma característica de qualidade que se refere à facilidade de uso e à experiência do usuário ao interagir com o software. Ela busca garantir que o software seja intuitivo, eficiente e agradável de usar.

### Proteção a erros

A proteção a erros é uma característica de qualidade que se concentra na capacidade do software de prevenir, detectar e lidar com erros de forma adequada. Essa característica busca garantir que o software seja resiliente e capaz de lidar com situações inesperadas, evitando falhas catastróficas e minimizando o impacto de erros no sistema.

Está característica foi escolhida por estar relacionada ao sistema de tratamento de erros, que é uma parte vital para que o sistema funcione corretamente.

#### Métrica

<table>
  <tr>
    <td align='center' colspan='3'><strong>Proteção a erros - 12pts</strong></td>
  </tr>
  <tr>
    <td colspan='3'>Com qual frequência o sistema se recupera após uma falhas?</td>
  </tr>
  <tr>
    <td width='100' align='center'><strong>Opção</strong></td>
    <td width='800' align='center'><strong>Descrição</strong></td>
    <td width='100' align='center'><strong>Pontuação</strong></td>
  </tr>
  <tr>
    <td align='center'>a)</td>
    <td>Não se recupera</td>
    <td>0 pts</td>
  </tr>
  <tr>
    <td align='center'>b)</td>
    <td>As vezes se recupera</td>
    <td>4 pts</td>
  </tr>
  <tr>
    <td align='center'>c)</td>
    <td>Na maioria das vezes se recupera</td>
    <td>8 pts</td>
  </tr>
  <tr>
    <td align='center'>d)</td>
    <td>Sempre se recupera</td>
    <td>12 pts</td>
  </tr>
</table>

### Apreensibilidade

A apreensibilidade é uma característica de qualidade que se concentra na facilidade de compreensão e aprendizado do software. Refere-se à capacidade do software de ser compreendido pelos usuários, mesmo sem conhecimentos prévios, e de fornecer informações claras e acessíveis.

Essa característica foi escolhido por trazer informações sobre a curva de aprendizado da aplicação, e em como os usuários tem se adaptado a ela.

#### Métrica

<table>
  <tr>
    <td align='center' colspan='3'><strong>Apreensibilidade - 12pts</strong></td>
  </tr>
  <tr>
    <td colspan='3'>Qual é a média de tempo para novos usuários aprenderem a usar a aplicação?</td>
  </tr>
  <tr>
    <td width='100' align='center'><strong>Opção</strong></td>
    <td width='800' align='center'><strong>Descrição</strong></td>
    <td width='100' align='center'><strong>Pontuação</strong></td>
  </tr>
  <tr>
    <td align='center'>a)</td>
    <td>1 mês</td>
    <td>0 pts</td>
  </tr>
  <tr>
    <td align='center'>b)</td>
    <td>2 semanas</td>
    <td>4 pts</td>
  </tr>
  <tr>
    <td align='center'>c)</td>
    <td>1 semana</td>
    <td>8 pts</td>
  </tr>
  <tr>
    <td align='center'>d)</td>
    <td>3 dias</td>
    <td>12 pts</td>
  </tr>
</table>

### Estética da interface

A estética da interface é uma característica de qualidade que se refere à aparência visual e ao design atrativo do software. Ela busca criar uma experiência agradável e envolvente para os usuários, com elementos visuais bem projetados, cores harmoniosas e layout organizado. A medição da estética da interface envolve a avaliação da consistência visual, a atratividade do design, a usabilidade dos elementos gráficos e a aderência a princípios de design de interface. 

Essa característica foi escolhida por estar relacionada a parte visual da aplicação e em como agrada o usuário.

#### Métrica

<table>
  <tr>
    <td align='center' colspan='3'><strong>Estética da interface - 6pts</strong></td>
  </tr>
  <tr>
    <td colspan='3'>A disposição dos itens da tela traz desconforto visualmente?</td>
  </tr>
  <tr>
    <td width='100' align='center'><strong>Opção</strong></td>
    <td width='800' align='center'><strong>Descrição</strong></td>
    <td width='100' align='center'><strong>Pontuação</strong></td>
  </tr>
  <tr>
    <td align='center'>a)</td>
    <td>Sim</td>
    <td>0 pts</td>
  </tr>
  <tr>
    <td align='center'>b)</td>
    <td>Um pouco</td>
    <td>4 pts</td>
  </tr>
  <tr>
    <td align='center'>c)</td>
    <td>Não</td>
    <td>6 pts</td>
  </tr>
</table>

## Manutenibilidade

A manutenibilidade é uma característica de qualidade fundamental em software, que se refere à facilidade e eficiência com que o software pode ser mantido e evoluído ao longo do tempo. Ela abrange a capacidade de compreender, modificar, corrigir e aprimorar o software de forma eficaz.

### Reusabilidade

A reusabilidade é uma característica de qualidade que se refere à capacidade do software de ser reutilizado em diferentes contextos ou partes do sistema. Ela busca maximizar a utilização de componentes, módulos ou funcionalidades existentes, reduzindo a necessidade de desenvolvimento repetitivo e aumentando a eficiência e a produtividade. 

Essa característica foi escolhida por estar ligada a padrões de clean code, que ajudam na hora de manter um código limpo e estruturado.

#### Métrica

<table>
  <tr>
    <td align='center' colspan='3'><strong>Reusabilidade - 12pts</strong></td>
  </tr>
  <tr>
    <td colspan='3'>Com que frequencia os componentes podem ser reutilizados?</td>
  </tr>
  <tr>
    <td width='100' align='center'><strong>Opção</strong></td>
    <td width='800' align='center'><strong>Descrição</strong></td>
    <td width='100' align='center'><strong>Pontuação</strong></td>
  </tr>
  <tr>
    <td align='center'>a)</td>
    <td>Não podem ser reutilizados</td>
    <td>0 pts</td>
  </tr>
  <tr>
    <td align='center'>b)</td>
    <td>Algum dos componentes podem ser reutilizados</td>
    <td>4 pts</td>
  </tr>
  <tr>
    <td align='center'>c)</td>
    <td>Quase todos os componentes podem ser reutilizados</td>
    <td>8 pts</td>
  </tr>
  <tr>
    <td align='center'>c)</td>
    <td>Todos os componentes podem ser reutilizados</td>
    <td>12 pts</td>
  </tr>
</table>

### Modularidade

A modularidade é uma característica de qualidade que se refere à capacidade do software de ser dividido em módulos independentes, cada um com uma responsabilidade bem definida e com interfaces claras de comunicação. Essa abordagem de design promove a organização e a estruturação do software em componentes isolados, permitindo a flexibilidade, a manutenibilidade e o reuso de partes específicas do sistema. 

Essa característica foi escolhida por estar ligada a padrões de clean code, que ajudam na hora de manter um código limpo e estruturado.

#### Métrica

<table>
  <tr>
    <td align='center' colspan='3'><strong>Reusabilidade - 10pts</strong></td>
  </tr>
  <tr>
    <td colspan='3'>Qual é relação de dependência entre módulos?</td>
  </tr>
  <tr>
    <td width='100' align='center'><strong>Opção</strong></td>
    <td width='800' align='center'><strong>Descrição</strong></td>
    <td width='100' align='center'><strong>Pontuação</strong></td>
  </tr>
  <tr>
    <td align='center'>a)</td>
    <td>Muito dependêntes</td>
    <td>0 pts</td>
  </tr>
  <tr>
    <td align='center'>b)</td>
    <td>Dependêntes</td>
    <td>4 pts</td>
  </tr>
  <tr>
    <td align='center'>c)</td>
    <td>Pouco dependêntes</td>
    <td>10 pts</td>
  </tr>
</table>
