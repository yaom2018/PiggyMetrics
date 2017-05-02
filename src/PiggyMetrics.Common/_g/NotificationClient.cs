// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: services/notification.proto
#region Designer generated code

using System; 
using System.Threading.Tasks; 
using DotBPE.Rpc; 
using DotBPE.Protocol.Amp; 
using DotBPE.Rpc.Exceptions; 
using Google.Protobuf; 

namespace PiggyMetrics.Common {

//start for class NotificationServiceClient
public sealed class NotificationServiceClient : AmpInvokeClient 
{
public NotificationServiceClient(IRpcClient<AmpMessage> client) : base(client)
{
}
public async Task<VoidRsp> UpdateStatisticsAsync(Account request,int timeOut=3000)
{
AmpMessage message = AmpMessage.CreateRequestMessage(1005, 1);
message.Data = request.ToByteArray();
var response = await base.CallInvoker.AsyncCall(message,timeOut);
if (response != null && response.Data !=null)
{
return VoidRsp.Parser.ParseFrom(response.Data);
}
throw new RpcException("请求出错，请检查!");
}

//同步方法
public VoidRsp UpdateStatistics(Account request)
{
AmpMessage message = AmpMessage.CreateRequestMessage(1005, 1);
message.Data = request.ToByteArray();
var response =  base.CallInvoker.BlockingCall(message);
if (response != null && response.Data !=null)
{
return VoidRsp.Parser.ParseFrom(response.Data);
}
throw new RpcException("请求出错，请检查!");
}
}
//end for class NotificationServiceClient
}
#endregion
