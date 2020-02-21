
CREATE DATABASE escola;
	
CREATE TABLE public.estudante
(
    estudanteid bigint NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 9223372036854775807 CACHE 1 ),
    email character(500) COLLATE pg_catalog."default" NOT NULL,
    nome character(500) COLLATE pg_catalog."default",
    CONSTRAINT pk_estudanteid PRIMARY KEY (estudanteid)
)

TABLESPACE pg_default;

ALTER TABLE public.estudante
    OWNER to postgres;

COMMENT ON COLUMN public.estudante.estudanteid
    IS 'chave primaria';