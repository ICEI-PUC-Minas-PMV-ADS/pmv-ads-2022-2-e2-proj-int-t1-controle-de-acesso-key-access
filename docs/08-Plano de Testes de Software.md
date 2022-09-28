# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-00X - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, CPF, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-02 – Efetuar login	|
|Requisito Associado | RF-00Y	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |

 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)




# Plano de Testes de Software

Os requisitos para realização dos testes de software são:
* Site publicado na Internet
* Navegador da Internet - Chrome, Firefox ou Edge
* Conectividade de Internet para acesso às plataformas (APISs)
Os testes funcionais a serem realizados no aplicativo são descritos a seguir.



| Caso de Teste 	| *  Cadastrar um novo morador*	|
|:---:	|:---:	|
|Requisito Associado | RF- Deve permitir que o usuário cadastre um novo morador |
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar um novo morador. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br>  - Preencher o campo de usuário <br> - Preencher o campo da senha <br> - Clicar em "Entrar" <br> -Na página inicial - aba adicionar - clicar em "+ Morador" <br> - Preencher os campos necessários <br> - Clicar em "Adicionar" |
|Critério de Êxito | - O novo morador foi criado com sucesso. |
|  	|  	|
| Caso de Teste 	| *  Cadastrar um novo visitante*	|
|Requisito Associado | RF- Deve permitir que o usuário cadastre um novo visitante, asssociando ao destino |
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar um novo visitante. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br>  - Preencher o campo de usuário <br> - Preencher o campo da senha <br> - Clicar em "Entrar" <br>  - Na página inicial - aba adicionar - clicar em "+ visitante" <br> - Preencher os campos necessários <br> - Clicar em "Adicionar" |
|Critério de Êxito | - O novo visitante foi criado com sucesso. |
|  	|  	|
| Caso de Teste 	| *  Cadastrar um novo funcionário*	|
|Requisito Associado | RF- Deve permitir que o usuário cadastre um funcionário |
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar um funcionário|
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Preencher o campo de usuário <br> - Preencher o campo da senha <br> - Clicar em "Entrar" <br>  - Na página inicial - aba adicionar - clicar em "+ funcionário"  <br> - Preencher os campos necessários <br> - Clicar em "Adicionar" |
|Critério de Êxito | - O novo prestador de serviço foi criado com sucesso. |
|  	|  	|
| Caso de Teste 	| *  Apagar um morador ou funcionário ou visitante*	|
|Requisito Associado | RF	- Deve permitir que o usuário apague um morador ou funcionário ou visitante. |
| Objetivo do Teste 	| Verificar se o usuário consegue apagar um morador ou funcionário ou visitante. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Preencher o campo de usuário <br> - Preencher o campo da senha <br> - Clicar em "Entrar" <br> -Na página inicial clicar em "morador ou funcionário ou visitante" <br> - Clicar em "Icone '-'" <br> - Clicar em "Confirmar"  |
|Critério de Êxito | - O contato foi apagado com sucesso. |
|  	|  	|
| Caso de Teste 	| *  Navegadores*	|
|Requisito Associado | RNF	Deve ser compatível com os principais navegadores do mercado. |
| Objetivo do Teste 	| Verificar se o usuário consegue visualizar a aplicação em outros navegadores. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Testar a aplicação em outros navegadores <br> |
|Critério de Êxito | - A aplicação é compatível com os principais navegadores do mercado . |
|  	|  	|

