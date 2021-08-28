﻿/*
Copyright 2021 Dicky Suryadi

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
 */

using System;

namespace DotNetify.Postgres
{
   public class DotNetifyPostgresException : Exception
   {
      public DotNetifyPostgresException(string message, Exception innerException = null) : base(message, innerException)
      {
         Logger.LogError($"[DotNetifyPostgres] {message}");
      }
   }
}