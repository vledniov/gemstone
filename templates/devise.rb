gem "devise"

run_bundle

model = ENV["MODEL"]
generate("devise:install")
generate("devise #{model}")


environment "config.action_mailer.default_url_options = { host: 'localhost', port: 3000 }", env: "development"
rake "db:migrate", env: "development"