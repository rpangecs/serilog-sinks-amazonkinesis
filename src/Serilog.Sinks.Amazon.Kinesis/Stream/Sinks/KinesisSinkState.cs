﻿// Copyright 2014 Serilog Contributors
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using Amazon.Kinesis;

namespace Serilog.Sinks.Amazon.Kinesis.Stream.Sinks
{
    internal class KinesisSinkState : KinesisSinkStateBase
    {
        internal KinesisSinkState(KinesisStreamSinkOptions options, IAmazonKinesis kinesisClient) : base(options)
        {
            if (options == null) throw new ArgumentNullException("options");
            if (kinesisClient == null) throw new ArgumentNullException("kinesisClient");
            KinesisClient = kinesisClient;
            Options = options;
        }

        public KinesisStreamSinkOptions Options { get; }
        public IAmazonKinesis KinesisClient { get; }
    }
}