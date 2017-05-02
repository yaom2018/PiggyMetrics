// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: services/account.proto
#region Designer generated code

using System; 
using System.Threading.Tasks; 
using DotBPE.Rpc; 
using DotBPE.Protocol.Amp; 
using Google.Protobuf; 

namespace PiggyMetrics.Common {

//start for class AbstractAccountService
public abstract class AccountServiceBase : IServiceActor<AmpMessage> 
{
public string Id => "1001$0";
//调用委托
private async Task ReceiveFindByNameAsync(IRpcContext<AmpMessage> context, AmpMessage req)
{
var request = FindAccountReq.Parser.ParseFrom(req.Data);
var data = await FindByNameAsync(request);
var response = AmpMessage.CreateResponseMessage(req.ServiceId, req.MessageId);
response.Sequence = req.Sequence;
response.Data = data.ToByteArray();
await context.SendAsync(response);
}

//抽象方法
public abstract Task<Account> FindByNameAsync(FindAccountReq request);
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
public abstract Task<Account> CreateAsync(User request);
//调用委托
private async Task ReceiveSaveAsync(IRpcContext<AmpMessage> context, AmpMessage req)
{
var request = Account.Parser.ParseFrom(req.Data);
var data = await SaveAsync(request);
var response = AmpMessage.CreateResponseMessage(req.ServiceId, req.MessageId);
response.Sequence = req.Sequence;
response.Data = data.ToByteArray();
await context.SendAsync(response);
}

//抽象方法
public abstract Task<VoidRsp> SaveAsync(Account request);
public Task ReceiveAsync(IRpcContext<AmpMessage> context, AmpMessage req)
{
//方法AccountService.FindByName
if(req.MessageId == 1){return this.ReceiveFindByNameAsync(context, req);}
//方法AccountService.Create
if(req.MessageId == 2){return this.ReceiveCreateAsync(context, req);}
//方法AccountService.Save
if(req.MessageId == 3){return this.ReceiveSaveAsync(context, req);}
return Task.CompletedTask;
}
}
//end for class AbstractAccountService
}

#endregion

