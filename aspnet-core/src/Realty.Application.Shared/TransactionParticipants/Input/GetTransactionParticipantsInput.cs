﻿using Abp.Runtime.Validation;
using Realty.Dto;
using System;

namespace Realty.TransactionParticipants.Input
{
    public class GetTransactionParticipantsInput : PagedAndSortedInputDto, IShouldNormalize
    {
        public string Filter { get; set; }

        public Guid? TransactionId { get; set; }

        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "FirstName";
            }

            Filter = Filter?.Trim();
        }
    }
}
