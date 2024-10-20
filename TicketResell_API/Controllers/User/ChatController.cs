﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketResell_API.Controllers.User.Model;
using TicketResell_API.Controllers.User.Service;

namespace TicketResell_API.Controllers.User
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IChatService _chatService;
        public ChatController(IChatService chatService)
        {
            _chatService = chatService;
        }

        [HttpGet("{seUserId}")]
        public async Task<ActionResult<List<Chat>>> GetChatsByUserId(string seUserId)
        {
            //get chat list by userId
            var chats = await _chatService.GetChatsByUserId(seUserId);
            //Check if no chat are found
            if (chats == null || !chats.Any())
            {
                return NotFound();
            }
            //Returns the list of chat
            return Ok(chats);

        }

        [HttpPost("post-chat")]
        public async Task<ActionResult<Chat>> PostChat([FromBody] Chat model)
        {
            //check the chat data and seUserId
            if (model == null || string.IsNullOrEmpty(model.seUserId))
            {
                return BadRequest("Chat data is null or Send User Id is missing. Please try again.");
            }
            //create and save chat
            var createChat = await _chatService.CreateChatAsync(model);
            //Returns the GetChatsByUserId and create a path to the newly created resource
            return CreatedAtAction(nameof(GetChatsByUserId), new { seUserId = createChat.seUserId }, createChat);
        }

        [HttpGet("message/{messageId}")]
        public async Task<ActionResult<Message>> GetMessageById(string messageId)
        {
            //get all messages belonging to chatId
            var message = await _chatService.GetMessageByIdAsync(messageId);
            //Check if no messages were found
            if (message == null || !messageId.Any())
            {
                return NotFound();
            }
            //Returns a list of messages
            return Ok(message);
        }

        [HttpPost("post-message")]
        public async Task<ActionResult<Message>> PostMessage([FromBody] Message model)
        {
            //check data and message is null or not
            if(model == null || string.IsNullOrEmpty(model.messageId))
            {
                return BadRequest("Message data is null or message id is missing. Please try again.");
            }
            //save message 
            var createdMessage = await _chatService.CreateMessageAsync(model);
            //Returns the GetMessageById and create a path to the newly created resource
            return CreatedAtAction(nameof(GetMessageById), new {messageId = createdMessage.messageId}, createdMessage);
        }
    }
}
