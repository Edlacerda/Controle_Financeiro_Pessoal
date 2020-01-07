# Controle_Financeiro_Pessoal
 Controle Financeiro Pessoal em C# WForms


O objetivo do programa é fazer um pequeno controle financeiro pessoal classificado, onde o usuário informará as movimentações de entrada e saída. 
Desta forma será possível gerar informações para identificar onde está sendo gasto seu dinheiro.
Também será possível verificar o saldo de cada conta do usuário (conta de banco, investimentos, dinheiro...).

Para tanto, o programa desenvolvido usando Visual Studio 2019 com o padrão MVC em C# .Net, com utilização de Wforms para o front.
O banco de dados feito em SQL Server (local), já com a adição de algumas classificações financeiras:

Categoria - Entrada e Saída

Classe - Remuneração, Transferência, Investimentos, Rendimentos e Outros (Entrada)
         Transferência, Alimentação, Aquisições, Banco, Comodidades, Doações, Educação, Habitação, Investimentos, Lazer, Presentes, Transporte e  Outros (Saída)

Conta - Dinheiro

Os arquivos mdf e ldf não commitaram, portanto será necessário reproduir o banco de dados com as querys contidas no arquivo "Query DBFinanceiro" contido na pasta Data.
A connectionString deverá ser atualizada no construtor da Classe Data, que se encontra na pasta model. 

O programa permitirá que o usuário:
Inclua/Exclua/Edite Classificações financeiras;
Inclua/Exclua/Edite Contas financeiras;
Inclua/Exclua/Edite movimentações financeiras;
Visualize um fluxo de caixa conforme classificações;
Visualize o saldo das contas e o total disponível.