using System.Collections.Generic;

namespace SAEA.MQTT.Packets
{
    public sealed class MqttSubscribePacketProperties
    {
        public uint? SubscriptionIdentifier { get; set; }

        public List<MqttUserProperty> UserProperties { get; set; }
    }
}
