namespace SAEA.MQTT.Server
{
    public class PrepareClientSessionResult
    {
        public bool IsExistingSession { get; set; }

        public MqttClientConnection Session { get; set; }
    }
}
