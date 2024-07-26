from sqlmodel import Session,SQLModel, create_engine,select

from app.core.config import settings
import app.models

# Create the database engine
engine = create_engine(settings.DATABASE_URL, pool_pre_ping=True)

# Set the echo flag to True if the environment is local
if settings.ENVIRONMENT == "local":
    engine.echo = True

def initDB():
    # Create the database tables
    SQLModel.metadata.create_all(engine)
    # Try to create session to check if DB is awake
    try:
        with Session(engine) as session:
            session.exec(select(1))
    except Exception as e:
        print("Database not awake: ", e)
        raise e