# KitchenOrderAPI-Kafka - Lista de Tarefas


## 1. Estrutura da Solução (.NET)
- [X] Criar Solution principal
  dotnet new sln -n KitchenOrderAPI-Kafka
- [X] Criar projeto KitchenOrderAPI (WebAPI)
  dotnet new webapi -n KitchenOrderAPI -o src/KitchenOrderAPI
- [X] Criar projeto KitchenMessaging (Class Library para Kafka)
  dotnet new classlib -n KitchenMessaging -o src/KitchenMessaging
- [X] Criar projeto KitchenConsumer (Console App)
  dotnet new console -n KitchenConsumer -o src/KitchenConsumer
- [X] Criar projeto KitchenOrderAPI.Tests (xUnit)
  dotnet new xunit -n KitchenOrderAPI.Tests -o src/KitchenOrderAPI.Tests
- [X] Adicionar todos os projetos à Solution
  dotnet sln KitchenOrderAPI-Kafka.sln add src/KitchenOrderAPI/KitchenOrderAPI.csproj
  dotnet sln KitchenOrderAPI-Kafka.sln add src/KitchenMessaging/KitchenMessaging.csproj
  dotnet sln KitchenOrderAPI-Kafka.sln add src/KitchenConsumer/KitchenConsumer.csproj
  dotnet sln KitchenOrderAPI-Kafka.sln add src/KitchenOrderAPI.Tests/KitchenOrderAPI.Tests.csproj

## 2. Endpoints da API (alta prioridade)
- [ ] Criar endpoint POST /api/orders (criar pedido)
- [ ] Criar endpoint GET /api/orders/{id} (consultar pedido por ID)
- [ ] Criar endpoint GET /api/orders (listar todos os pedidos)
- [ ] Criar endpoint PUT /api/orders/{id}/status (atualizar status do pedido)
- [ ] Criar endpoint DELETE /api/orders/{id} (cancelar pedido)
- [ ] Criar endpoint POST /api/auth/token (geração de token JWT)
- [ ] Configurar autenticação/autorização via JWT
- [ ] Documentar endpoints no Swagger

## 3. Configuração do Kafka (alta prioridade)
- [ ] Configurar docker-compose com Kafka + Zookeeper
- [ ] Criar tópico `orders`
- [ ] Implementar Kafka Producer na API
- [ ] Implementar Kafka Consumer (Kitchen Consumer)
- [ ] Configurar retry e dead-letter topic
- [ ] Documentar fluxo de mensagens no `architecture.md`

## 4. Testes Unitários (prioridade média)
- [ ] Criar testes para Controllers
- [ ] Criar testes para Services
- [ ] Criar testes para Kafka Producer
- [ ] Criar testes para Kafka Consumer
- [ ] Garantir cobertura mínima de 80%

## 5. Testes de Stress (prioridade média)
- [ ] Configurar ferramenta de stress test (ex.: k6 ou JMeter)
- [ ] Criar cenários de carga para POST /api/orders
- [ ] Criar cenários de carga para Kafka Producer
- [ ] Criar cenários de carga para Kafka Consumer
- [ ] Documentar resultados e métricas

## 6. Configuração de Log (prioridade média)
- [ ] Configurar Serilog na API
- [ ] Criar logs estruturados (JSON)
- [ ] Configurar sinks (console, arquivo, Elasticsearch opcional)
- [ ] Criar correlação de logs por request ID
- [ ] Documentar boas práticas de logging

## 7. Documentação (prioridade baixa)
- [ ] Finalizar README trilingue
- [ ] Finalizar docs/arquitetura.md trilingue com diagramas
- [ ] Documentar setup local (docker-compose, appsettings.json)

## 8  . CI/CD (prioridade baixa)
- [ ] Configurar pipeline de build (GitHub Actions ou Azure DevOps)
- [ ] Configurar pipeline de testes unitários
- [ ] Configurar pipeline de testes de stress
- [ ] Configurar deploy automatizado (Docker ou Kubernetes)



## 9. Dependências NuGet
- [ ] API
  dotnet add src/KitchenOrderAPI/KitchenOrderAPI.csproj package Microsoft.AspNetCore.Authentication.JwtBearer
  dotnet add src/KitchenOrderAPI/KitchenOrderAPI.csproj package Swashbuckle.AspNetCore
  dotnet add src/KitchenOrderAPI/KitchenOrderAPI.csproj package Serilog.AspNetCore
- [ ] Messaging
  dotnet add src/KitchenMessaging/KitchenMessaging.csproj package Confluent.Kafka
- [ ] Consumer
  dotnet add src/KitchenConsumer/KitchenConsumer.csproj package Confluent.Kafka
  dotnet add src/KitchenConsumer/KitchenConsumer.csproj package Serilog
- [ ] Tests
  dotnet add src/KitchenOrderAPI.Tests/KitchenOrderAPI.Tests.csproj package Microsoft.AspNetCore.Mvc.Testing
  dotnet add src/KitchenOrderAPI.Tests/KitchenOrderAPI.Tests.csproj package Moq

10. Estrutura mínima esperada
    KitchenOrderAPI (WebAPI)
        Controllers/OrdersController.cs
        Services/OrderService.cs
        Program.cs
        appsettings.json

    KitchenMessaging (Class Library)
        Producer/OrderProducer.cs
        Consumer/OrderConsumer.cs
        KafkaConfig.cs

    KitchenConsumer (Console App)
        Program.cs
        Services/KitchenService.cs

    KitchenOrderAPI.Tests (xUnit)
        Controllers/OrdersControllerTests.cs
        Services/OrderServiceTests.cs