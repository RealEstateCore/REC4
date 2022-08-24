[Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Demand_Sensor](../Demand_Sensor.md) > [Cooling_Demand_Sensor](Cooling_Demand_Sensor.md) > [Average_Cooling_Demand_Sensor](.)
# Average_Cooling_Demand_Sensor

**Display name:** Average Cooling Demand Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Average_Cooling_Demand_Sensor;1

---
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
