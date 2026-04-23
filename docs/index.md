# 🚀 Project Management System

Добро пожаловать в документацию **Project Management System** — мощной системы для управления проектами и задачами.

---

## 📖 О проекте

Project Management System — это современное решение для командной работы, построенное на принципах **Domain-Driven Design (DDD)** и **Clean Architecture**.

### ✨ Основные возможности

| Функция | Описание |
|---------|----------|
| 📋 **Управление проектами** | Создание, редактирование и отслеживание проектов |
| ✅ **Управление задачами** | Назначение, приоритеты, статусы и дедлайны |
| 👥 **Командная работа** | Роли, разрешения и совместный доступ |
| 📊 **Отчёты и аналитика** | Статистика по проектам и задачам |
| 🔔 **Уведомления** | Оповещения о изменениях и дедлайнах |

---

## 🏗️ Архитектура

Проект построен на 4 архитектурных слоях: 
```text
┌─────────────────────────────────────────────┐
│ Presentation Layer                          │
│ (Console Application)                       │
├─────────────────────────────────────────────┤
│ Application Layer                           │
│ (Commands, Queries, Handlers)               │
├─────────────────────────────────────────────┤
│ Domain Layer                                │
│ (Entities, Value Objects)                   │
├─────────────────────────────────────────────┤
│ Infrastructure Layer                        │
│ (Repositories, Data Access)                 │
└─────────────────────────────────────────────┘
```

---

## 🎯 Быстрый старт

### Требования
- .NET 8.0 или выше
- PostgreSQL 
### Установка

```bash
# Клонирование репозитория
git clone https://github.com/yourusername/ProjectManagement.git

# Переход в папку проекта
cd ProjectManagement

# Сборка решения
dotnet build
```
### Запуск
```bash
cd src/ProjectManagement.Presentation/ProjectManagement.Presentation.Console
dotnet run
```
