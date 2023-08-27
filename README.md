<!DOCTYPE html>
<html>
<head>
    <title>Projeto CRUD de Fornecedor utilizando ASP.NET Core MVC</title>
</head>
<body>

<h1>Projeto CRUD de Fornecedor utilizando ASP.NET Core MVC</h1>

<p>Este repositório contém um projeto desenvolvido em ASP.NET Core MVC que implementa operações CRUD (Create, Read, Update, Delete) para o gerenciamento de fornecedores. O projeto permite a inserção, visualização, atualização e exclusão de informações de fornecedores, incluindo Nome, CNPJ, Especialidade, CEP, Rua, Número, Bairro, Cidade e Estado.</p>

<p>Uma funcionalidade notável deste projeto é a integração com um serviço de busca de endereços através do CEP. Quando um CEP é inserido, os campos de Rua, Bairro, Cidade e Estado são preenchidos automaticamente, proporcionando uma experiência mais conveniente para o usuário.</p>

<h2>Funcionalidades</h2>

<ul>
    <li><strong>Cadastro de Fornecedores:</strong> Os usuários podem cadastrar novos fornecedores informando os detalhes necessários, incluindo Nome, CNPJ, Especialidade e CEP.</li>
    <li><strong>Busca de Endereço por CEP:</strong> Ao inserir um CEP válido, os campos de endereço (Rua, Bairro, Cidade, Estado) são preenchidos automaticamente, economizando tempo e reduzindo erros.</li>
    <li><strong>Visualização de Fornecedores:</strong> A lista de fornecedores cadastrados pode ser visualizada em uma interface amigável, permitindo que os usuários vejam informações básicas de cada fornecedor.</li>
    <li><strong>Atualização de Informações:</strong> Os usuários têm a capacidade de editar os detalhes dos fornecedores registrados, incluindo a atualização automática dos campos de endereço ao modificar o CEP.</li>
    <li><strong>Remoção de Fornecedores:</strong> Fornecedores podem ser removidos do sistema, eliminando suas informações da base de dados.</li>
</ul>

<h2>Configuração</h2>

<ol>
    <li>Certifique-se de ter o ambiente de desenvolvimento ASP.NET Core configurado em sua máquina.</li>
    <li>Clone este repositório para o seu sistema local:<br>
        <code>git clone https://github.com/seu-usuario/nome-do-repositorio.git</code></li>
    <li>Abra o projeto em sua IDE ou editor de código preferido.</li>
    <li>Configure as conexões de banco de dados e outras configurações relevantes, se necessário.</li>
    <li>Execute o projeto e acesse-o em seu navegador para começar a utilizar as funcionalidades do CRUD de Fornecedores.</li>
</ol>

<h2>Tecnologias Utilizadas</h2>

<ul>
    <li>ASP.NET Core MVC</li>
    <li>C#</li>
    <li>HTML5</li>
    <li>CSS3</li>
    <li>Entity Framework Core (para a interação com o banco de dados)</li>
    <li>Serviço de Busca de Endereços por CEP (API externa)</li>
</ul>

<h2>Contribuição</h2>

<p>Contribuições são bem-vindas! Se você encontrou algum problema, deseja adicionar recursos adicionais ou melhorar a funcionalidade existente, sinta-se à vontade para abrir uma issue ou enviar um pull request.</p>

</body>
</html>
