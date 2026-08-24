KitchenOrderAPI - Kafka Integration
===================================

Objetivo
--------
Criar uma API Restful em C# para gerenciamento de pedidos de cozinha utilizando Kafka como mensageria. 
A API deve receber pedidos, publicar mensagens no Kafka e permitir que a cozinha consuma essas mensagens para coordenar o preparo dos pratos.

Estrutura do Projeto
--------------------
KitchenOrderAPI-Kafka/
│
├── src/
│   ├── KitchenOrderAPI/        -> Projeto principal da API
│   ├── KitchenOrderAPI.Tests/  -> Projeto de testes unitários
│
├── docs/
│   └── arquitetura.md          -> Documentação da arquitetura
│
├── .gitignore
├── README.md
├── LICENSE
└── docker-compose.yml          -> Configuração para Kafka e API

------------------------------------------------------------
🇧🇷 Português
------------------------------------------------------------
API Restful em C# para gerenciamento de pedidos de cozinha utilizando Kafka como mensageria.

🚀 Funcionalidades
- Receber pedidos via endpoint REST
- Publicar mensagens no Kafka
- Consumir mensagens para a cozinha
- Documentação via Swagger
- Testes unitários com xUnit
- Logs com Serilog

📦 Instalação
git clone https://github.com/<seu-usuario>/KitchenOrderAPI-Kafka.git
cd KitchenOrderAPI-Kafka
dotnet restore

▶️ Execução
dotnet run
Acesse: http://localhost:5000/swagger

🤝 Contribuição
1. Faça um fork do projeto
2. Crie uma branch (git checkout -b feature/nova-feature)
3. Commit suas alterações (git commit -m 'Adiciona nova feature')
4. Push para a branch (git push origin feature/nova-feature)
5. Abra um Pull Request

------------------------------------------------------------
🇺🇸 English
------------------------------------------------------------
Restful API in C# for kitchen order management using Kafka as messaging system.

🚀 Features
- Receive orders via REST endpoint
- Publish messages to Kafka
- Consume messages for kitchen processing
- Swagger documentation
- Unit tests with xUnit
- Logging with Serilog

📦 Installation
git clone https://github.com/<your-user>/KitchenOrderAPI-Kafka.git
cd KitchenOrderAPI-Kafka
dotnet restore

▶️ Run
dotnet run
Access: http://localhost:5000/swagger

🤝 Contribution
1. Fork the project
2. Create a branch (git checkout -b feature/new-feature)
3. Commit your changes (git commit -m 'Add new feature')
4. Push to the branch (git push origin feature/new-feature)
5. Open a Pull Request

------------------------------------------------------------
🇪🇸 Español
------------------------------------------------------------
API Restful en C# para la gestión de pedidos de cocina utilizando Kafka como sistema de mensajería.

🚀 Funcionalidades
- Recibir pedidos vía endpoint REST
- Publicar mensajes en Kafka
- Consumir mensajes para la cocina
- Documentación con Swagger
- Pruebas unitarias con xUnit
- Logs con Serilog

📦 Instalación
git clone https://github.com/<tu-usuario>/KitchenOrderAPI-Kafka.git
cd KitchenOrderAPI-Kafka
dotnet restore

▶️ Ejecución
dotnet run
Acceder: http://localhost:5000/swagger

🤝 Contribución
1. Haz un fork del proyecto
2. Crea una rama (git checkout -b feature/nueva-funcionalidad)
3. Haz commit de tus cambios (git commit -m 'Agrega nueva funcionalidad')
4. Push a la rama (git push origin feature/nueva-funcionalidad)
5. Abre un Pull Request
