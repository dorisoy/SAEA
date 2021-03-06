using SAEA.MQTT.Protocol;

namespace SAEA.MQTT.Packets
{
    /// <summary>
    /// Added in MQTTv5.0.0.
    /// </summary>
    public sealed class MqttAuthPacket : MqttBasePacket
    {
        public MqttAuthenticateReasonCode ReasonCode { get; set; }

        public MqttAuthPacketProperties Properties { get; set; }
    }
}
