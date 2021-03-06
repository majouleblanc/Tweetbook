﻿using Microsoft.AspNetCore.Mvc;

namespace Tweetbook.Contracts.v1.Requests
{
    public class UpdatePostRequest
    {
        [FromRoute]
        public long Id { get; set; }
        [FromBody]
        public string Name { get; set; }
    }
}