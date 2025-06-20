﻿using System;
using System.Threading.Tasks;

namespace tusdotnet.Models.Configuration
{
    /// <summary>
    /// Events supported by tusdotnet
    /// </summary>
    public class Events
    {
        /// <summary>
        /// Callback ran right before a file upload starts. This callback can be used to validate
        /// the request before starting the upload. Calling the <see cref="ValidationContext{TSelf}.FailRequest(string)" /> method on the context
        /// will return a 400 Bad Request to the client.
        /// </summary>
        public Func<BeforeWriteContext, Task> OnBeforeWriteAsync { get; set; }

        /// <summary>
        /// Callback ran when a file is completely uploaded.
        /// This callback is called only once after the last bytes have been written to the store or
        /// after a "final" file has been created using the concatenation extension.
        /// It will not be called for any subsequent requests for already completed files.
        /// </summary>
        public Func<FileCompleteContext, Task> OnFileCompleteAsync { get; set; }

        /// <summary>
        /// Callback ran right before a file is created. This callback can be used to validate
        /// files before they are created. Calling the <see cref="ValidationContext{TSelf}.FailRequest(string)" /> method on the context
        /// will return a 400 Bad Request to the client.
        /// </summary>
        public Func<BeforeCreateContext, Task> OnBeforeCreateAsync { get; set; }

        /// <summary>
        /// Callback ran when a file has been created.
        /// </summary>
        public Func<CreateCompleteContext, Task> OnCreateCompleteAsync { get; set; }

        /// <summary>
        /// Callback ran right before a file is deleted. This callback can be used to validate
        /// that a file can be deleted. Calling the <see cref="ValidationContext{TSelf}.FailRequest(string)" /> method on the context
        /// will return a 400 Bad Request to the client.
        /// </summary>
        public Func<BeforeDeleteContext, Task> OnBeforeDeleteAsync { get; set; }

        /// <summary>
        /// Callback ran when a file has been deleted.
        /// </summary>
        public Func<DeleteCompleteContext, Task> OnDeleteCompleteAsync { get; set; }

        /// <summary>
        /// Callback ran before the request is being handled. This callback can be used to authorize the current request.
        /// Calling the <see cref="ValidationContext{TSelf}.FailRequest(string)" /> method on the context will return a 400 Bad Request to the client.
        /// </summary>
        public Func<AuthorizeContext, Task> OnAuthorizeAsync { get; set; }
    }
}
