﻿using MediatR;

namespace ConfirmTransactions.Microservice.Commands.ConfirmTransaction.ConfirmWalletBalance
{
    public class ConfirmWalletBalanceCommand : IRequest
    {
        public int TransactionId { get; set; }
        public int BuyerId { get; set; }
        public decimal Price { get; set; }
    }
}
