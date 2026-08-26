namespace KitchenShared.Constant;
public static class LogMessages
    {
        // Informações gerais
        public const string ConsumerStarted = "Consumidor iniciado no tópico {Topic}";
        public const string MessageReceived = "Mensagem recebida no tópico {Topic}: {Message}";
        public const string MessagePublished = "Mensagem publicada no tópico {Topic}: {Message}";

        // Erros
        public const string JsonDeserializationError = "Erro de desserialização JSON no tópico {Topic}: {Error}";
        public const string UnexpectedConsumerError = "Erro inesperado ao consumir mensagens do tópico {Topic}: {Error}";
        public const string ProducerError = "Erro ao publicar mensagem no tópico {Topic}: {Error}";
    }