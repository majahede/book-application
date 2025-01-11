DO
$$
BEGIN
    IF NOT EXISTS (SELECT 1 FROM pg_database WHERE datname = 'bookdb') THEN
        CREATE DATABASE bookdb;
    END IF;
END
$$;

CREATE TABLE books (
    id UUID PRIMARY KEY,
    title VARCHAR(50) NOT NULL
);

INSERT INTO books (id, title) VALUES
    ('550e8400-e29b-41d4-a716-446655440000', 'The Great Gatsby'),
    ('550e8400-e29b-41d4-a716-446655440001', 'The Hobbit'),
    ('550e8400-e29b-41d4-a716-446655440002', 'Dune'),
    ('550e8400-e29b-41d4-a716-446655440003', 'Pride and Prejudice'),
    ('550e8400-e29b-41d4-a716-446655440004', 'The Road');