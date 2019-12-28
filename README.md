# Controle_Financeiro_Pessoal
 Controle Financeiro Pessoal em C# WForms


O objetivo do programa é fazer um pequeno controle financeiro pessoal classificado, onde o usuário informará as movimentações de entrada e saída. Desta forma será possível gerar informações para identificar onde está sendo gasto seu dinheiro.

Para tanto, o programa desenvolvido usando o padrão MVC em C# .Net, com utilização de Wforms para o front.
O banco de dados será feito em SQL Server (local), já com a adição de algumas classificações financeiras:

Categoria - Entrada e Saída

Classe - Investimentos, Remuneração, Rendimentos e Outros (Entrada)
         Alimentação, Aquisições, Banco, Comodidades, Doações, Educação, Habitação, Investimentos, Lazer, Presentes, Transporte e  Outros (Saída)

O programa permitirá que o usuário:
Inclua/Exclua Classificações financeiras;
Inclua/Exclua/Edite movimentações financeiras;
Visualize um fluxo de caixa conforme classificações;
Visualize, em uma curva ABC (maior para menor), os maiores valores de entrada e saída.