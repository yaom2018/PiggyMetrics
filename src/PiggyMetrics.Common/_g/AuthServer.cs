// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: services/auth.proto
#region Designer generated code

using System; 
using System.Threading.Tasks; 
using DotBPE.Rpc; 
using DotBPE.Protocol.Amp; 
using Google.Protobuf; 

namespace PiggyMetrics.Common {

//start for class AbstractAuthService
public abstract class AuthServiceBase : IServiceActor<AmpMessage> 
{
public string Id => "1002$0";
//调用委托
private async Task ReceiveCreateAsync(IRpcContext<AmpMessage> context, AmpMessage req)
{
var request = User.Parser.ParseFrom(req.Data);
var data = await CreateAsync(request);
var response = AmpMessage.CreateResponseMessage(req.ServiceId, req.MessageId);
response.Sequence = req.Sequence;
response.Data = data.ToByteArray();
await context.SendAsync(response);
}

//抽象方法
public abstract Task<VoidRsp> CreateAsync(User request);
//调用委托
private async Task ReceiveAuthAsync(IRpcContext<AmpMessage> context, AmpMessage req)
{
var request = User.Parser.ParseFrom(req.Data);
var data = await AuthAsync(request);
var response = AmpMessage.CreateResponseMessage(req.ServiceId, req.MessageId);
response.Sequence = req.Sequence;
response.Data = data.ToByteArray();
await context.SendAsync(response);
}

//抽象方法
public abstract Task<AuthRsp> AuthAsync(User request);
public Task ReceiveAsync(IRpcContext<AmpMessage> context, AmpMessage req)
{
//方法AuthService.Create
if(req.MessageId == 1){return this.ReceiveCreateAsync(context, req);}
//方法AuthService.Auth
if(req.MessageId == 2){return this.ReceiveAuthAsync(context, req);}
return Task.CompletedTask;
}
}
//end for class AbstractAuthService
}

#endregion
