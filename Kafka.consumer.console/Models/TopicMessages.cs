namespace Kafka.consumer.console.Models
{
    public class TopicMessages
    {
        public int Id { get; set; }

        public string Topic { get; set; }

        public long Offset { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }

    }
}
