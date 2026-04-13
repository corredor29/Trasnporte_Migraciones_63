# Capa 1 — Sin dependencias (primero estas)


countries


## Capa 2 — Dependen solo de capa 1

stateorregion → countries
type_documents → document_category
persons → person_status
plans → (independiente pero base de suscripciones)

Capa 3 — Dependen de capa 2

cities_commune_qualities → stateorregion
person_roles → persons, roles
auth_credentials → persons
auth_sessions → persons, auth_credentials
customers → persons
drivers → persons
transport_companies → companies_status
vehicles → vehicules_status, type_load
audit_log → persons
notifications → persons, notification_type


Capa 4 — Dependen de capa 3

documents_drivers → drivers, type_documents, documents_status
documents_customers → customers, type_documents, documents_status
drivers_vehicles → drivers, vehicles
company_vehicles → transport_companies, vehicles
documents_vehicles → vehicles, type_documents, documents_status
ratings → persons
person_plans → persons, plans
subscriptions → persons, plans, subscription_type, subscription_status
credit_wallet → persons, transport_companies
chat_rooms → (base de chat)
status_chat → (catálogo independiente)


Capa 5 — Dependen de capa 4

city_pricing_rules → cities_commune_qualities, type_load
price_history → cities_commune_qualities, type_load
credit_transactions → credit_wallet, transaction_types
chat_participants → chat_rooms, persons
chat_messages → chat_rooms, persons, message_type


Capa 6 — Módulo de cargas y viajes

loads → persons, transport_companies, cities_commune_qualities, type_load
load_images → loads
load_status_history → loads
load_actual → loads
load_suggestions → loads
trip_desires → loads, drivers
trips → loads, drivers, customers, vehicles


Capa 7 — Historial y asignaciones

trip_assignments → trips, drivers, assignment_role
trip_status_history → trips
travel_scale → trips
person_transport → persons, trips


Capa 8 — Pagos y disputas

payments → trips, payment_providers, payment_statuses, credit_wallet
disputes → trips, persons, reason_disputes, disputes_status


Capa 9 — Tablas de oferta/demanda y facturación

bids → loads, drivers, transport_companies
driver_bids → bids, drivers