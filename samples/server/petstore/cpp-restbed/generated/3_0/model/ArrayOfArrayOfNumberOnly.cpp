/**
 * OpenAPI Petstore
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI-Generator 7.0.1-SNAPSHOT.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */



#include "ArrayOfArrayOfNumberOnly.h"

#include <string>
#include <vector>
#include <map>
#include <sstream>
#include <stdexcept>
#include <regex>
#include <boost/lexical_cast.hpp>
#include <boost/property_tree/ptree.hpp>
#include <boost/property_tree/json_parser.hpp>
#include "helpers.h"

using boost::property_tree::ptree;
using boost::property_tree::read_json;
using boost::property_tree::write_json;

namespace org {
namespace openapitools {
namespace server {
namespace model {

ArrayOfArrayOfNumberOnly::ArrayOfArrayOfNumberOnly(boost::property_tree::ptree const& pt)
{
        fromPropertyTree(pt);
}


std::string ArrayOfArrayOfNumberOnly::toJsonString(bool prettyJson /* = false */) const
{
	std::stringstream ss;
	write_json(ss, this->toPropertyTree(), prettyJson);
    // workaround inspired by: https://stackoverflow.com/a/56395440
    std::regex reg("\\\"([0-9]+\\.{0,1}[0-9]*)\\\"");
    std::string result = std::regex_replace(ss.str(), reg, "$1");
    return result;
}

void ArrayOfArrayOfNumberOnly::fromJsonString(std::string const& jsonString)
{
	std::stringstream ss(jsonString);
	ptree pt;
	read_json(ss,pt);
	this->fromPropertyTree(pt);
}

ptree ArrayOfArrayOfNumberOnly::toPropertyTree() const
{
	ptree pt;
	ptree tmp_node;
	// generate tree for ArrayArrayNumber
    tmp_node.clear();
	if (!m_ArrayArrayNumber.empty()) {
        tmp_node = toPt(m_ArrayArrayNumber);
		pt.add_child("ArrayArrayNumber", tmp_node);
		tmp_node.clear();
	}
	return pt;
}

void ArrayOfArrayOfNumberOnly::fromPropertyTree(ptree const &pt)
{
	ptree tmp_node;
	// push all items of ArrayArrayNumber into member
	if (pt.get_child_optional("ArrayArrayNumber")) {
        m_ArrayArrayNumber = fromPt<std::vector<std::vector<double>>>(pt.get_child("ArrayArrayNumber"));
	}
}

std::vector<std::vector<double>> ArrayOfArrayOfNumberOnly::getArrayArrayNumber() const
{
    return m_ArrayArrayNumber;
}

void ArrayOfArrayOfNumberOnly::setArrayArrayNumber(std::vector<std::vector<double>> value)
{
    m_ArrayArrayNumber = value;
}



std::vector<ArrayOfArrayOfNumberOnly> createArrayOfArrayOfNumberOnlyVectorFromJsonString(const std::string& json)
{
    std::stringstream sstream(json);
    boost::property_tree::ptree pt;
    boost::property_tree::json_parser::read_json(sstream,pt);

    auto vec = std::vector<ArrayOfArrayOfNumberOnly>();
    for (const auto& child: pt) {
        vec.emplace_back(ArrayOfArrayOfNumberOnly(child.second));
    }

    return vec;
}

}
}
}
}

