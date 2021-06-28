﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssettoServer.Network.Packets.Outgoing.Handshake
{
    public struct NoSlotsAvailableResponse : IOutgoingNetworkPacket
    {
        public void ToWriter(ref PacketWriter writer)
        {
            writer.Write<byte>(0x45);
        }
    }
}
