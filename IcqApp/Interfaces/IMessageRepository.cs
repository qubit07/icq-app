﻿using IcqApp.DTOs;
using IcqApp.Entities;
using IcqApp.Helpers;

namespace IcqApp.Interfaces
{
    public interface IMessageRepository
    {
        void AddMessage(Message message);
        void DeleteMessage(Message message);
        Task<Message> GetMessage(int id);
        Task<PagedList<MessageDto>> GetMessagesForUser(MessageParams messageParams);
        Task<IEnumerable<MessageDto>> GetMessageThread(string currentUsername, string recipientUsername);
        void AddGroup(Group group);
        void RemoveConnection(Connection connection);
        Task<Connection> GetConnectionById(string connectionId);
        Task<Group> GetMessageGroup(string groupName);
        Task<Group> GetMessageGroupByConnectionId(string connectionId);

    }
}
