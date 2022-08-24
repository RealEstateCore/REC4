[Point](../../Point.md) > [Setpoint](../Setpoint.md) > [Demand_Setpoint](Demand_Setpoint.md) > [Preheat_Demand_Setpoint](.)
# Preheat_Demand_Setpoint
**DTMI:** dtmi:org:brickschema:schema:Brick:Preheat_Demand_Setpoint;1
## Display name
- **en:** Preheat Demand Setpoint
## Description
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|array (string)|False|
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Point;1:** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name
## Target Of
### Inherited
* Asset.hasPoint
* EquipmentCollection.hasPoint
* ActuationEvent.targetPoint
* ExceptionEvent.sourcePoint
* ObservationEvent.sourcePoint
* ServiceObject.producedBy
* Architecture.hasPoint