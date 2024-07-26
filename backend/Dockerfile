FROM tiangolo/uvicorn-gunicorn-fastapi:python3.10

WORKDIR /app

COPY requirements.txt .
RUN pip install --no-cache-dir -r requirements.txt

COPY ./prestart.sh /app

COPY /tests-start.sh /app

COPY ./app /app/app