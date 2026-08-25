KitchenOrderAPI - Kafka Integration
===================================

**Português** | [English](#english) | [Español](#espanol)

------------------------------------------------------------
<a id="portugues"></a>
🇧🇷 Português
------------------------------------------------------------

Objetivo
--------
Criar uma API Restful em C# para gerenciamento de pedidos de cozinha utilizando Kafka como mensageria. 
A API deve receber pedidos, publicar mensagens no Kafka e permitir que a cozinha consuma essas mensagens para coordenar o preparo dos pratos.

Estrutura do Projeto
--------------------
```
KitchenOrderAPI-Kafka/
│
├── src/
│   ├── KitchenOrderAPI/        -> Projeto principal da API (garçons lançam pedidos)
│   ├── KitchenMessaging/       -> Biblioteca de integração com Kafka (Producer/Consumer)
│   ├── KitchenConsumer/        -> Projeto da cozinha (consome pedidos e processa)
│   ├── KitchenOrderAPI.Tests/  -> Projeto de testes unitários
│
├── docs/
│   └── architecture.md          -> Documentação da arquitetura
│
├── .gitignore
├── README.md
├── LICENSE
└── docker-compose.yml          -> Configuração para Kafka, API e Consumers
```

🌐 Portfólio
Acesse o portfólio do autor: https://thiagopeteanselma.github.io/Thiago-Selma-Portfolio/

Funcionalidades
- Receber pedidos via endpoint REST
- Publicar mensagens no Kafka
- Consumir mensagens para a cozinha
- Documentação via Swagger
- Testes unitários com xUnit
- Logs com Serilog

Instalação
git clone https://github.com/ThiagoPeteanSelma/KitchenOrderAPI-Kafka.git
cd KitchenOrderAPI-Kafka
dotnet restore

Execução
dotnet run
Acesse: http://localhost:5000/swagger

Contribuição
1. Faça um fork do projeto
2. Crie uma branch (git checkout -b feature/nova-feature)
3. Commit suas alterações (git commit -m 'Adiciona nova feature')
4. Push para a branch (git push origin feature/nova-feature)
5. Abra um Pull Request

Autor
-----
Thiago Petean Selma  
Líder Técnico | Engenheiro de Software .NET  
GitHub: https://github.com/thiagopeteanselma  
LinkedIn: https://www.linkedin.com/in/thiagopeteanselma  
Email: thiagopetean@gmail.com  

Última atualização: 2026-08-24

------------------------------------------------------------
<a id="english"></a>
🇺🇸 English
------------------------------------------------------------

Objective
---------
Create a Restful API in C# for kitchen order management using Kafka as a messaging system.  
The API should receive orders, publish messages to Kafka, and allow the kitchen to consume these messages to coordinate dish preparation.

Project Structure
-----------------
```
KitchenOrderAPI-Kafka/
│
├── src/
│   ├── KitchenOrderAPI/        -> Main API project
│   ├── KitchenMessaging/       -> Kafka integration library (Producer/Consumer)
│   ├── KitchenConsumer/        -> Kitchen project (consumes and processes orders)
│   ├── KitchenOrderAPI.Tests/  -> Unit test project
│
├── docs/
│   └── architecture.md          -> Architecture documentation
│
├── .gitignore
├── README.md
├── LICENSE
└── docker-compose.yml          -> Kafka and API configuration
```

🌐 Portfolio
Visit the author's portfolio: https://thiagopeteanselma.github.io/Thiago-Selma-Portfolio/

Features
- Receive orders via REST endpoint
- Publish messages to Kafka
- Consume messages for kitchen processing
- Swagger documentation
- Unit tests with xUnit
- Logging with Serilog

Installation
git clone https://github.com/ThiagoPeteanSelma/KitchenOrderAPI-Kafka.git
cd KitchenOrderAPI-Kafka
dotnet restore

Run
dotnet run
Access: http://localhost:5000/swagger

Contribution
1. Fork the project
2. Create a branch (git checkout -b feature/new-feature)
3. Commit your changes (git commit -m 'Add new feature')
4. Push to the branch (git push origin feature/new-feature)
5. Open a Pull Request

Author
------
Thiago Petean Selma  
Technical Lead | .NET Software Engineer  
GitHub: https://github.com/thiagopeteanselma  
LinkedIn: https://www.linkedin.com/in/thiagopeteanselma  
Email: thiagopetean@gmail.com  

Last update: 2026-08-24

------------------------------------------------------------
<a id="espanol"></a>
🇪🇸 Español
------------------------------------------------------------

Objetivo
--------
Crear una API Restful en C# para la gestión de pedidos de cocina utilizando Kafka como sistema de mensajería.  
La API debe recibir pedidos, publicar mensajes en Kafka y permitir que la cocina consuma estos mensajes para coordinar la preparación de los platos.

Estructura del Proyecto
-----------------------
```
KitchenOrderAPI-Kafka/
│
├── src/
│   ├── KitchenOrderAPI/        -> Proyecto principal de la API
│   ├── KitchenMessaging/       -> Biblioteca de integración con Kafka (Productor/Consumidor)
│   ├── KitchenConsumer/        -> Proyecto de la cocina (consume pedidos y los procesa)
│   ├── KitchenOrderAPI.Tests/  -> Proyecto de pruebas unitarias
│
├── docs/
│   └── architecture.md          -> Documentación de la arquitectura
│
├── .gitignore
├── README.md
├── LICENSE
└── docker-compose.yml          -> Configuración para Kafka y API
```

🌐 Portafolio
Visita el portafolio del autor: https://thiagopeteanselma.github.io/Thiago-Selma-Portfolio/

Funcionalidades
- Recibir pedidos vía endpoint REST
- Publicar mensajes en Kafka
- Consumir mensajes para la cocina
- Documentación con Swagger
- Pruebas unitarias con xUnit
- Logs con Serilog

Instalación
git clone https://github.com/ThiagoPeteanSelma/KitchenOrderAPI-Kafka.git
cd KitchenOrderAPI-Kafka
dotnet restore

Ejecución
dotnet run
Acceder: http://localhost:5000/swagger

Contribución
1. Haz un fork del proyecto
2. Crea una rama (git checkout -b feature/nueva-funcionalidad)
3. Haz commit de tus cambios (git commit -m 'Agrega nueva funcionalidad')
4. Push a la rama (git push origin feature/nueva-funcionalidad)
5. Abre un Pull Request

Autor
-----
Thiago Petean Selma  
Líder Técnico | Ingeniero de Software .NET  
GitHub: https://github.com/thiagopeteanselma  
LinkedIn: https://www.linkedin.com/in/thiagopeteanselma  
Email: thiagopetean@gmail.com  

Última actualización: 2026-08-24