# API_REST

API criada para o desafio de projeto do bootcamp da [Dio.me](https://web.dio.me/track/pottencial-net-developer).

Foi utilizado o .NET(C#), juntamente com o Swagger e o MySql como banco de dados.

O objetivo era fazer um CRUD em que uma venda necessite de um vendedor atrelado a ela, e que somente pode alterar o status da venda.

O meior desafio nesta etapa foi de fazer com que as duas tabelas se relacione, porém como podem ver no [Vídeo de Demonstração](https://youtu.be/AIr8XDpVucM), consegui realizar estas questões, porém faltou a parte das atualizações  que deveriam obedecer as seguintes transições:

**De**: Aguardando pagamento  **Para**: Pagamento Aprovado
**De**: Aguardando pagamento   **Para**: Cancelada
**De**: Pagamento Aprovado    **Para**: Enviado para Transportadora
**De**: Pagamento Aprovado   **Para**: Cancelada
**De**: Enviado para Transportador. **Para**: Entregue

# Tecnologias utilizadas:

<img alt=".NET" src="https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white">
<img alt="C#" src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white">
<img alt="MySql" src="https://img.shields.io/badge/MySQL-00000F?style=for-the-badge&logo=mysql&logoColor=white">
<img alt="swagger" src="https://img.shields.io/badge/-Swagger-%23Clojure?style=for-the-badge&logo=swagger&logoColor=white">

# IDE

![Visual Studio Code](https://img.shields.io/badge/Visual%20Studio%20Code-0078d7.svg?style=for-the-badge&logo=visual-studio-code&logoColor=white)
