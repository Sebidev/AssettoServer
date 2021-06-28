﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssettoServer.Network.Packets.Outgoing.Handshake
{
    public struct AuthFailedResponse : IOutgoingNetworkPacket
    {
        public readonly string Reason;

        public AuthFailedResponse(string reason)
        {
            Reason = reason;
        }

        public void ToWriter(ref PacketWriter writer)
        {
            writer.Write<byte>(0x6F);
            writer.WriteUTF32String(Reason);
        }
    }
}
