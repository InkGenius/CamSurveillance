using System;
using System.Net;
using StreamCoders.Network;

namespace RTPServer
{
    public class RtpFramer
    {
        public readonly RTPSession Session;

        public RTPSender Sender;//发送者
        public RTPReceiver Receiver;//接收者

        private RTPParticipant participant;
        private RTPParticipant senderParticipant;

        public RtpFramer(String RTPipAddress, int RTPport, String RTCPipAddress, int RTCPport, String forwardIP, int forwardPort)
        {
            Session = new RTPSession();
            Sender = new RTPSender();
            Receiver = new RTPReceiver();

            var senderEp = new IPEndPoint(IPAddress.Parse(forwardIP), forwardPort);
            senderParticipant = new RTPParticipant(senderEp);
            Sender.AddParticipant(senderParticipant);
            Session.AddSender(Sender);

            var rtpEp = new IPEndPoint(IPAddress.Parse(RTPipAddress), RTPport);
            var rtcpEp = new IPEndPoint(IPAddress.Parse(RTCPipAddress), RTCPport);
            participant = new RTPParticipant(rtpEp, rtcpEp);
            Session.NewRTPPacket = NewRTPPacket;
            Session.NewRTCPPacket = NewRTCPPacket;
            Receiver.AddParticipant(participant);
            Session.AddReceiver(Receiver);
        }

        private bool NewRTPPacket(RTPPacket packet)
        {
            Console.WriteLine(packet.ToString());
            return true;
        }

        private void NewRTCPPacket(RTCPCompoundPacket packet)
        {
        }
    }
}