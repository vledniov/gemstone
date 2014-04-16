model = ENV["MODEL"]
attrs = ENV["ATTRS"].gsub(" ", "").split(",")

generate(:model, "#{model} #{attrs.join(' ')}")