ALTER TABLE users
ADD CONSTRAINT DF_users_type
DEFAULT 'user' FOR type;