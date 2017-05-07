// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: services/statistic.proto
#region Designer generated code

using System;
using System.Threading.Tasks;
using DotBPE.Rpc;
using DotBPE.Protocol.Amp;
using DotBPE.Rpc.Exceptions;
using Google.Protobuf;

namespace PiggyMetrics.Common
{

    //start for class StatisticServiceClient
    public sealed class StatisticServiceClient : AmpInvokeClient
    {
        public StatisticServiceClient(IRpcClient<AmpMessage> client) : base(client)
        {
        }
        public async Task<VoidRsp> UpdateStatisticsAsync(Account request, int timeOut = 3000)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(1003, 1);
            message.Data = request.ToByteArray();
            var response = await base.CallInvoker.AsyncCall(message, timeOut);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            if (response.Data == null)
            {
                return new VoidRsp();
            }
            return VoidRsp.Parser.ParseFrom(response.Data);
        }

        //同步方法
        public VoidRsp UpdateStatistics(Account request)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(1003, 1);
            message.Data = request.ToByteArray();
            var response = base.CallInvoker.BlockingCall(message);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            if (response.Data == null)
            {
                return new VoidRsp();
            }
            return VoidRsp.Parser.ParseFrom(response.Data);
        }
        public async Task<StatRsp> FindByAccountAsync(FindAccountReq request, int timeOut = 3000)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(1003, 2);
            message.Data = request.ToByteArray();
            var response = await base.CallInvoker.AsyncCall(message, timeOut);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            if (response.Data == null)
            {
                return new StatRsp();
            }
            return StatRsp.Parser.ParseFrom(response.Data);
        }

        //同步方法
        public StatRsp FindByAccount(FindAccountReq request)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(1003, 2);
            message.Data = request.ToByteArray();
            var response = base.CallInvoker.BlockingCall(message);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            if (response.Data == null)
            {
                return new StatRsp();
            }
            return StatRsp.Parser.ParseFrom(response.Data);
        }
    }
    //end for class StatisticServiceClient
}
#endregion
