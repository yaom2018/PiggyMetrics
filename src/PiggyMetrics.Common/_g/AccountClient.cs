// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: services/account.proto
#region Designer generated code

using System; 
using System.Threading.Tasks; 
using DotBPE.Rpc; 
using DotBPE.Protocol.Amp; 
using DotBPE.Rpc.Exceptions; 
using Google.Protobuf; 

namespace PiggyMetrics.Common {

//start for class AccountServiceClient
public sealed class AccountServiceClient : AmpInvokeClient 
{
public AccountServiceClient(IRpcClient<AmpMessage> client) : base(client)
{
}
public async Task<Account> FindByNameAsync(FindAccountReq request,int timeOut=3000)
{
AmpMessage message = AmpMessage.CreateRequestMessage(1001, 1);
message.Data = request.ToByteArray();
var response = await base.CallInvoker.AsyncCall(message,timeOut);
if (response != null && response.Data !=null)
{
return Account.Parser.ParseFrom(response.Data);
}
throw new RpcException("请求出错，请检查!");
}

//同步方法
public Account FindByName(FindAccountReq request)
{
AmpMessage message = AmpMessage.CreateRequestMessage(1001, 1);
message.Data = request.ToByteArray();
var response =  base.CallInvoker.BlockingCall(message);
if (response != null && response.Data !=null)
{
return Account.Parser.ParseFrom(response.Data);
}
throw new RpcException("请求出错，请检查!");
}
public async Task<Account> CreateAsync(User request,int timeOut=3000)
{
AmpMessage message = AmpMessage.CreateRequestMessage(1001, 2);
message.Data = request.ToByteArray();
var response = await base.CallInvoker.AsyncCall(message,timeOut);
if (response != null && response.Data !=null)
{
return Account.Parser.ParseFrom(response.Data);
}
throw new RpcException("请求出错，请检查!");
}

//同步方法
public Account Create(User request)
{
AmpMessage message = AmpMessage.CreateRequestMessage(1001, 2);
message.Data = request.ToByteArray();
var response =  base.CallInvoker.BlockingCall(message);
if (response != null && response.Data !=null)
{
return Account.Parser.ParseFrom(response.Data);
}
throw new RpcException("请求出错，请检查!");
}
public async Task<VoidRsp> SaveAsync(Account request,int timeOut=3000)
{
AmpMessage message = AmpMessage.CreateRequestMessage(1001, 2);
message.Data = request.ToByteArray();
var response = await base.CallInvoker.AsyncCall(message,timeOut);
if (response != null && response.Data !=null)
{
return VoidRsp.Parser.ParseFrom(response.Data);
}
throw new RpcException("请求出错，请检查!");
}

//同步方法
public VoidRsp Save(Account request)
{
AmpMessage message = AmpMessage.CreateRequestMessage(1001, 2);
message.Data = request.ToByteArray();
var response =  base.CallInvoker.BlockingCall(message);
if (response != null && response.Data !=null)
{
return VoidRsp.Parser.ParseFrom(response.Data);
}
throw new RpcException("请求出错，请检查!");
}
}
//end for class AccountServiceClient
}
#endregion