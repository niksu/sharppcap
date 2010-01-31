using System;
using NUnit.Framework;
using SharpPcap;
using SharpPcap.Util;

namespace Test
{
    [TestFixture]
    public class InvalidPacketTest
    {
        // Test behavior when a IPPacket with an invalid length is parsed
        //
        // We expect to get an EthernetPacket since the IPPacket contained in the EthernetPacket
        // isn't valid
        [Test]
        public void IPPacketInvalidLength()
        {
            throw new System.InvalidOperationException("Migrate test to Packet.Net");
#if false
            var dev = new OfflinePcapDevice("../../capture_files/ip_packet_bogus_length.pcap");
            dev.Open();

            try
            {
                Packet p;
                int packetIndex = 0;
                while((p = dev.GetNextPacket()) != null)
                {
                    Console.WriteLine("got packet");

                    Assert.IsTrue(p is EthernetPacket);

                    packetIndex++;
                }
            } finally
            {
                dev.Close();
            }
#endif
        }
    }
}
