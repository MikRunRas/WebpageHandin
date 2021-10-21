using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Models;

namespace LoginExample.Data.Impl {
public class InMemoryUserService : IUserService {
    private List<User> users;
    private string userFile = "users.json";

    public InMemoryUserService() {
        string content = File.ReadAllText(userFile);
        users = JsonSerializer.Deserialize<List<User>>(content);
        users.ToList();
    }


    public User ValidateUser(string userName, string password) {
        User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
        if (first == null) {
            throw new Exception("User not found");
        }

        if (!first.Password.Equals(password)) {
            throw new Exception("Incorrect password");
        }

        return first;
    }
}
}