namespace DotNetLightning.LN

open DotNetLightning.Utils
open DotNetLightning.Serialize.Msgs
open NBitcoin

type PeerEvent =
    | Connected of theirNodeId: NodeId
    | ReceivedError of theirNodeId: NodeId * error: ErrorMessage
    | ReceivedPing of theirNodeId: NodeId * ping: Ping
    | ReceivedPong of theirNodeId: NodeId * ping: Pong
    | ReceivedInit of theirNodeId: NodeId * init: Init
    | ReceivedRoutingMsg of theirNodeId: NodeId * msg: IRoutingMsg
    | ReceivedChannelMsg of theirNodeId: NodeId * msg: IChannelMsg
    | FailedToBroadcastTransaction of theirNodeId: NodeId * tx: Transaction

type PeerCommand =
    | Connect of theirPeerId: PeerId * theirNodeId: NodeId
    | SendPing of theirPeerId: PeerId * ping: Ping