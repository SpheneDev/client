using Sphene.API.Data;
using MessagePack;

namespace Sphene.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record OnlineUserIdentDto(UserData User, string Ident) : UserDto(User);
