using System;
using System.Linq;
using SilverZone.Domain.Users;

namespace SilverZone.Domain.Impl.Users
{
    public  class UserRepository: IUserRepository
    {
        public Result Save(User user)
        {
            if (user == null)
                throw new ArgumentNullException("user");
            
            Result result = new Result();

            Data.DataContext.UsingContext(ctx =>
                {
                    Data.User dataUser;

                    //check add or update
                    bool isNew = user.Id == Guid.Empty;

                    if (isNew)
                    {
                        user.Id = Guid.NewGuid();
                        //add
                        dataUser = new Data.User();
                    }
                    else
                    {
                        // update
                        dataUser = ctx.Users.FirstOrDefault(x => x.Id == user.Id);
                        if (dataUser == null)
                        {
                            result.HasErrors = true;
                            result.Message = "User not found: " + user.Id;
                        }
                    }

                    if (!result.HasErrors)
                    {
                        // update data user from domain user
                        dataUser.UpdateFromDomainEntity(user);

                        if (isNew)
                        {
                            ctx.Users.Add(dataUser);
                        }
                    }
                });


            return result;
        }

        public User Get(Guid id)
        {
            //create variable
            User user = null;

            Data.DataContext.UsingContext(ctx => user = ctx.Users.FirstOrDefault(x =>x.Id == id).ToDomainEntity());

            return user;
        }

        public User Get(string username)
        {
            User user = null;

            Data.DataContext.UsingContext(ctx => user = ctx.Users.FirstOrDefault(x => x.UserName == username).ToDomainEntity());

            return user;
        }

        public Result Delete(User user)
        {
            if (user == null)
             throw new ArgumentNullException("user");
           
            Result result = new Result();

            Data.DataContext.UsingContext(ctx =>
                {
                   Data.User dataUser = ctx.Users.FirstOrDefault(x => x.Id == user.Id);

                    if (dataUser == null)
                    {
                        result.HasErrors = true;
                        result.Message = "User not found: " + user.Id;
                    }
                    else
                    {
                        ctx.Users.Remove(dataUser);
                    }
                });

            return result;
        }
    }
}
