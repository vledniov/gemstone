gem_group(:test) do
  gem "rspec-rails"
  gem "capybara" if ENV["FEATURE"]
end

run_bundle

generate("rspec:install")
run "rmdir /Q /S test"