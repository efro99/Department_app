create table department (
    ID integer,
    department_name varchar(500),
    department_description varchar(4000),
    department_status bit,
    department_creation_date datetime,
    department_last_update_date datetime,
    constraint pk_department_id  PRIMARY KEY (ID)
);

create table users (
    ID integer,
    user_logon datetime,
    user_first_name varchar(500),
    user_last_name varchar(4000),
    user_department_id integer,
    user_start_date datetime,
    user_end_date datetime,
    constraint pk_user_id  PRIMARY KEY (ID),
    constraint fk_user_department_id FOREIGN key (user_department_id) REFERENCE department(id)
);

create table roles (
    ID integer,
    role_name varchar(500),
    role_start_date datetime,
    role_end_date datetime,
    constraint pk_roles_id  PRIMARY KEY (ID)
);

create table user_roles (
    role_id integer,
    role_start_date datetime,
    role_end_date datetime,
    department_status bit,
    CONSTRAINT fk_role_id FOREIGN key (role_id) REFERENCE roles(id)
);