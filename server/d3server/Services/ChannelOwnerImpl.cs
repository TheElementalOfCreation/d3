﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bnet.protocol.channel;

namespace d3server.Services {
	public class ChannelOwnerImpl: ChannelOwner {
		Client client;
		public ChannelOwnerImpl(Client client) {
			this.client = client;
		}

		public override void GetChannelId(Google.ProtocolBuffers.IRpcController controller, GetChannelIdRequest request, Action<GetChannelIdResponse> done) {
			throw new NotImplementedException();
		}

		public override void CreateChannel(Google.ProtocolBuffers.IRpcController controller, CreateChannelRequest request, Action<CreateChannelResponse> done) {
			throw new NotImplementedException();
		}

		public override void JoinChannel(Google.ProtocolBuffers.IRpcController controller, JoinChannelRequest request, Action<JoinChannelResponse> done) {
			throw new NotImplementedException();
		}

		public override void FindChannel(Google.ProtocolBuffers.IRpcController controller, FindChannelRequest request, Action<FindChannelResponse> done) {
			throw new NotImplementedException();
		}

		public override void GetChannelInfo(Google.ProtocolBuffers.IRpcController controller, GetChannelInfoRequest request, Action<GetChannelInfoResponse> done) {
			throw new NotImplementedException();
		}
	}
}