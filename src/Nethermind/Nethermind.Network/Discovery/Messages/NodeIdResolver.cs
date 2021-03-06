﻿/*
 * Copyright (c) 2018 Demerzel Solutions Limited
 * This file is part of the Nethermind library.
 *
 * The Nethermind library is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * The Nethermind library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License
 * along with the Nethermind. If not, see <http://www.gnu.org/licenses/>.
 */

using Nethermind.Core.Crypto;
using Nethermind.Core.Extensions;
using Nethermind.Core.Model;

namespace Nethermind.Network.Discovery.Messages
{
    public class NodeIdResolver : INodeIdResolver
    {
        private readonly ISigner _signer;

        public NodeIdResolver(ISigner signer)
        {
            _signer = signer;
        }

        public NodeId GetNodeId(byte[] signature, int recoveryId, byte[] messageType, byte[] data)
        {
            //return _signer.RecoverPublicKey(discoveryMessage.Signature, Keccak.Compute(Bytes.Concat(new[] {(byte)discoveryMessage.MessageType}, discoveryMessage.Payload)));

            var key = _signer.RecoverPublicKey(new Signature(signature, recoveryId), Keccak.Compute(Bytes.Concat(messageType, data)));
            return key != null ? new NodeId(key) : null;
        }
    }
}